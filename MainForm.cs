using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PokemonHGSSMoveEditor
{
    public partial class mainForm : Form, IMoveEditorView
    {
        private IMoveEditorController controller = MoveEditorController.getInstance();

        public mainForm()
        {
            InitializeComponent();

            //event handlers
            moveComboBx.SelectedValueChanged += new EventHandler(moveComboBx_SelectedValueChanged);
            effectMaskTxtBx.Validating += new CancelEventHandler(effectMaskTxtBx_Validating);
            powerMaskTxtBx.Validating += new CancelEventHandler(powerMaskTxtBx_Validating);
            accuracyMaskTxtBx.Validating += new CancelEventHandler(accuracyMaskTxtBx_Validating);
            ppMaskTxtBx.Validating += new CancelEventHandler(ppMaskTxtBx_Validating);
            effectChanceMaskTxtBx.Validating += new CancelEventHandler(effectChanceMaskTxtBx_Validating);
            priorityMaskTxtBx.Validating += new CancelEventHandler(priorityMaskTxtBx_Validating);
            contestEffectMaskTxtBx.Validating += new CancelEventHandler(contestEffectMaskTxtBx_Validating);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                categoryComboBx.Items.Add(category);
            }

            foreach (ContestCondition condition in Enum.GetValues(typeof(ContestCondition)))
            {
                contestConditionComboBx.Items.Add(condition);
            }

            foreach (Target target in Enum.GetValues(typeof(Target)))
            {
                targetComboBx.Items.Add(target);
            }

            controller.setView(this);
            controller.setModel(MoveEditorModel.getInstance());

            showMoveList(controller.getMoveList());
            showMoveTypes(controller.getTypeList());

            if (!selectFile())
            {
                this.Close();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            (int[] oldMoveData, bool[] flags) = controller.getOldValues();

            showMoveData(oldMoveData, flags);
        }

        private void showMoveList(List<string> moveList)
        {
            moveComboBx.Items.Clear();

            moveComboBx.BeginUpdate();
            foreach (string move in moveList)
            {
                moveComboBx.Items.Add(move);
            }
            moveComboBx.EndUpdate();
        }

        private void showMoveTypes(List<string> typeList)
        {
            typeComboBx.Items.Clear();

            foreach (string type in typeList)
            {
                typeComboBx.Items.Add(type.ToUpper());
            }
        }

        private bool selectFile()
        {
            OpenFileDialog chooseFile;
            
            //label for jumping to if the file is not readable or the wrong file
            openFile:

            chooseFile = new OpenFileDialog();
            chooseFile.Filter = "NDS Roms (*.nds)|*.nds|All files (*.*)|*.*";
            chooseFile.InitialDirectory = Directory.GetCurrentDirectory();
            chooseFile.FilterIndex = 0;
            chooseFile.RestoreDirectory = true;

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(chooseFile.FileName))
                {
                    return false;
                }

                //if the moveData can't be loaded (because of a problem reading the file) jump back to have the user select a new file
                if (!controller.loadMoveData(chooseFile.FileName))
                {
                    goto openFile;
                }

                //checks if a move has been selected, which occurs only after the first time moveData is loaded, then all the current form text is discarded for the currently stored moveData
                //this is done to prevent a bug in which the previous form text ends up stored as moveData after opening a new file while the move editor is open
                if (moveComboBx.SelectedIndex >= 0)
                {
                    (int[] moveData, bool[] flags) = controller.getMoveData(moveComboBx.SelectedIndex);

                    showMoveData(moveData, flags);
                }

                moveComboBx.SelectedIndex = 0;
                this.Text = this.Text.Replace("*", "");

                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayError(string errorMsg)
        {
            MessageBox.Show(errorMsg);
        }

        public void displayError(string errorMsg, string exceptionMsg)
        {
            MessageBox.Show(errorMsg + "\n\n" + exceptionMsg);
        }
        

        private void moveComboBx_SelectedValueChanged(object sender, EventArgs e)
        {
            if (moveComboBx.SelectedIndex == -1)
            {
                moveComboBx.SelectedIndex = controller.getPreviousMoveIndex();
            }
            
            (int[] moveData, bool[] flags) = controller.getMoveData(moveComboBx.SelectedIndex);

            updateMoveData();

            showMoveData(moveData, flags);
            controller.storeOldValues(moveData, flags);

            //stores the index of the current move so that it can be retrieved after the selected move has changed for updateMoveData()
            controller.setPreviousMoveIndex(moveComboBx.SelectedIndex);
        }


        private void updateMoveData()
        {
            int[] moveData = new int[Constants.NUMMOVEDATABYTES];
            bool[] flags = new bool[Constants.NUMFLAGS];

            //checks if the form has loaded data into controls, only one control needs to be checked since data is loaded into all controls at the same time
            if (!string.IsNullOrEmpty(effectMaskTxtBx.Text))
            {
                moveData[Constants.EFFECTINDEX] = int.Parse(effectMaskTxtBx.Text);
                moveData[Constants.CATEGORYINDEX] = (int)categoryComboBx.SelectedItem;
                moveData[Constants.POWERINDEX] = int.Parse(powerMaskTxtBx.Text);
                moveData[Constants.TYPEINDEX] = typeComboBx.SelectedIndex;
                moveData[Constants.ACCURACYINDEX] = int.Parse(accuracyMaskTxtBx.Text);
                moveData[Constants.PPINDEX] = int.Parse(ppMaskTxtBx.Text);
                moveData[Constants.EFFECTCHANCEINDEX] = int.Parse(effectChanceMaskTxtBx.Text);
                moveData[Constants.TARGETINDEX] = (int)targetComboBx.SelectedItem;
                moveData[Constants.PRIORITYINDEX] = (byte)sbyte.Parse(priorityMaskTxtBx.Text);
                moveData[Constants.CONTESTEFFECTINDEX] = int.Parse(contestEffectMaskTxtBx.Text);
                moveData[Constants.CONTESTCONDITIONINDEX] = (int)contestConditionComboBx.SelectedItem;

                flags[Constants.CONTACTFLAGINDEX] = contactCheckBx.Checked;
                flags[Constants.PROTECTFLAGINDEX] = protectCheckBx.Checked;
                flags[Constants.MAGICCOATFLAGINDEX] = magicCoatCheckBx.Checked;
                flags[Constants.SNATCHFLAGINDEX] = snatchCheckBx.Checked;
                flags[Constants.MIRRORMOVEFLAGINDEX] = mirrorMoveCheckBx.Checked;
                flags[Constants.KINGSROCKFLAGINDEX] = kingsRockCheckBx.Checked;
                flags[Constants.KEEPHPBARFLAGINDEX] = keepHPBarCheckBx.Checked;
                flags[Constants.HIDESHADOWFLAGINDEX] = hideShadowCheckBx.Checked;

                if (controller.updateMoveData(moveData, flags, controller.getPreviousMoveIndex()))
                {
                    if (!this.Text.Contains("*"))
                    {
                        this.Text += "*";
                    }
                }
            }
        }

        private void showMoveData(int[] moveData, bool[] flags)
        {
            effectMaskTxtBx.Text = (moveData[Constants.EFFECTINDEX]).ToString();
            categoryComboBx.SelectedIndex = moveData[Constants.CATEGORYINDEX];
            powerMaskTxtBx.Text = (moveData[Constants.POWERINDEX]).ToString();
            typeComboBx.SelectedIndex = moveData[Constants.TYPEINDEX];
            accuracyMaskTxtBx.Text = (moveData[Constants.ACCURACYINDEX]).ToString();
            ppMaskTxtBx.Text = (moveData[Constants.PPINDEX]).ToString();
            effectChanceMaskTxtBx.Text = (moveData[Constants.EFFECTCHANCEINDEX]).ToString();
            targetComboBx.SelectedItem = (Target)moveData[Constants.TARGETINDEX];
            priorityMaskTxtBx.Text = (moveData[Constants.PRIORITYINDEX]).ToString();
            contestEffectMaskTxtBx.Text = (moveData[Constants.CONTESTEFFECTINDEX]).ToString();
            contestConditionComboBx.SelectedIndex = moveData[Constants.CONTESTCONDITIONINDEX];

            contactCheckBx.Checked = flags[Constants.CONTACTFLAGINDEX];
            protectCheckBx.Checked = flags[Constants.PROTECTFLAGINDEX];
            magicCoatCheckBx.Checked = flags[Constants.MAGICCOATFLAGINDEX];
            snatchCheckBx.Checked = flags[Constants.SNATCHFLAGINDEX];
            mirrorMoveCheckBx.Checked = flags[Constants.MIRRORMOVEFLAGINDEX];
            kingsRockCheckBx.Checked = flags[Constants.KINGSROCKFLAGINDEX];
            keepHPBarCheckBx.Checked = flags[Constants.KEEPHPBARFLAGINDEX];
            hideShadowCheckBx.Checked = flags[Constants.HIDESHADOWFLAGINDEX];
        }


        private void saveAsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMoveData();

            var chooseFile = new SaveFileDialog
            {
                Filter = "All files (*.*)|*.*",
                InitialDirectory = Directory.GetCurrentDirectory(),
                RestoreDirectory = true
            };

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                controller.saveToBinFile(chooseFile.FileName);
                this.Text = this.Text.Replace("*", "");
            }

        }

        private void saveToRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMoveData();

            var chooseFile = new OpenFileDialog
            {
                Filter = "Ninetendo DS Roms (*.nds*)|*.nds*",
                InitialDirectory = Directory.GetCurrentDirectory(),
                RestoreDirectory = true
            };

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                controller.writeToRom(chooseFile.FileName);
                this.Text = this.Text.Replace("*", "");
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMoveData();

            if (controller.getIsUnsavedChanges())
            {
                if (MessageBox.Show("There are unsaved changes. Do you want to discard changes made and open a new file anyway?", "Pokemon Gen 4 Move Editor",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    selectFile();
                }
            }
            else
            {
                selectFile();
            }
        }

        private void newTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var typeInputForm = new userTextInputForm("Enter name of the type to be created");
            typeInputForm.ShowDialog();


            if(typeInputForm.inputText != "")
            {
                controller.addNewType(typeInputForm.inputText);
                typeComboBx.Items.Add(typeInputForm.inputText.ToUpper());
            }
        }

        private void newMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var moveInputForm = new userTextInputForm("Enter name of the move to be created");
            moveInputForm.ShowDialog();


            if (moveInputForm.inputText != "")
            {
                
                moveComboBx.Items.Add(moveInputForm.inputText.ToUpper());
                controller.addNewMove(moveInputForm.inputText);
            }

            moveComboBx.SelectedIndex = moveComboBx.Items.Count - 1;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void effectMaskTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controller.inputMoveDataValid(effectMaskTxtBx.Text, MoveDataType.EFFECT))
            {
                effectMaskTxtBx.Text = controller.getOldValues().Item1[Constants.EFFECTINDEX].ToString();
            }
        }

        private void powerMaskTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controller.inputMoveDataValid(powerMaskTxtBx.Text, MoveDataType.POWER))
            {
                powerMaskTxtBx.Text = controller.getOldValues().Item1[Constants.POWERINDEX].ToString();

            }
        }

        private void accuracyMaskTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controller.inputMoveDataValid(accuracyMaskTxtBx.Text, MoveDataType.ACCURACY))
            {
                accuracyMaskTxtBx.Text = controller.getOldValues().Item1[Constants.ACCURACYINDEX].ToString();
            }
        }

        private void ppMaskTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controller.inputMoveDataValid(ppMaskTxtBx.Text, MoveDataType.PP))
            {
                ppMaskTxtBx.Text = controller.getOldValues().Item1[Constants.PPINDEX].ToString();
            }
        }

        private void effectChanceMaskTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controller.inputMoveDataValid(effectChanceMaskTxtBx.Text, MoveDataType.EFFECTCHANCE))
            {
                effectChanceMaskTxtBx.Text = controller.getOldValues().Item1[Constants.EFFECTCHANCEINDEX].ToString();
            }
        }

        private void priorityMaskTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controller.inputMoveDataValid(priorityMaskTxtBx.Text, MoveDataType.PRIORITY))
            {
                priorityMaskTxtBx.Text = (controller.getOldValues().Item1[Constants.PRIORITYINDEX]).ToString();
            }
        }

        private void contestEffectMaskTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!controller.inputMoveDataValid(contestEffectMaskTxtBx.Text, MoveDataType.CONTESTEFFECT))
            {
                contestEffectMaskTxtBx.Text = controller.getOldValues().Item1[Constants.CONTESTEFFECTINDEX].ToString();
            }
        }


        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            updateMoveData();

            if (controller.getIsUnsavedChanges())
            {
                if (MessageBox.Show("There are unsaved changes. Do you want to discard changes made and close anyway?", "Pokemon Gen 4 Move Editor",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        
    }
}
