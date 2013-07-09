using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHomework {
    class DownloadClass {

        internal void openFile() {
            Stream myStream = null;
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    // ReSharper disable ConditionIsAlwaysTrueOrFalse
                    if ((myStream = openFileDialog1.OpenFile()) != null) {
                        using (myStream) {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
