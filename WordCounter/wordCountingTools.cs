using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;

// There was no need for instances of this class, static is enough
public static class wordCountingTools
{

    // Known word separators
    private static char[] separators = { ' ', '\n', '\t', ',', ':', '!', '?', '.', '"', '\'' };

    // Collection of scanned words (as keys) 
    // and their numbers of appearances (as values)
    private static Dictionary<string, int> wordCollection = new Dictionary<string, int>();
    

    // Save handling
    private static bool hasBeenSaved = false;
    private static string saveFileName;


    public static void openAndLoad(ListView listView1)
    {
        // Indicating that results from the newly
        // loaded file have not yet been saved
        hasBeenSaved = false;
        saveFileName = "";

        OpenFileDialog open = new OpenFileDialog
        {
            Title = "Pick your file",
            Filter = "Text files(*txt)|*txt"
        };

        // Clearing listView for new words
        listView1.Items.Clear();
        listView1.Update();
        listView1.Refresh();

        wordCollection.Clear();

        if (open.ShowDialog() == DialogResult.OK)
        {
            try
            {
                using (StreamReader reader = File.OpenText(open.FileName))
                {


                    // Reading from input file
                    List<string> line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine().Trim().Split(separators).ToList();
                        foreach (string word in line)
                        {
                            // Word compatibility check
                            if (word.Length > 1 && word.Any(x => char.IsLetterOrDigit(x)))
                            {
                                // Adding into collection
                                if (wordCollection.ContainsKey(word))
                                {
                                    wordCollection[word] += 1;
                                }
                                else
                                {
                                    wordCollection.Add(word, 1);
                                }
                            }
                        }
                    }

                    // Filling the ListView
                    foreach (KeyValuePair<string, int> kvp in wordCollection)
                    {
                        var listElement = new ListViewItem(kvp.Key);
                        var listSubElement = new ListViewItem.ListViewSubItem(listElement, kvp.Value.ToString());

                        listElement.SubItems.Add(listSubElement);
                        listView1.Items.Add(listElement);
                    }

                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

    }

    public static void save(ListView listView1)
    {

        if (!hasBeenSaved)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Title = "Save",
                Filter = "Text files(*txt)|*txt"
            };

            var dialogResult = save.ShowDialog();
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Saving the name of saved file  
                    // for future saving if needed
                    if (save.FileName.EndsWith(".txt"))
                    {
                        saveFileName = save.FileName;
                    }
                    else
                    {
                        saveFileName = save.FileName + ".txt";
                    }
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

            }
        }

        // Saving to save file
        if (!String.IsNullOrEmpty(saveFileName))
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(saveFileName))
                {
                    foreach (ListViewItem lvi in listView1.Items)
                    {
                        string line = lvi.Text + " - " + lvi.SubItems[1].Text;
                        writer.WriteLine(line);
                    }

                    // Indicating that file has been saved
                    hasBeenSaved = true;

                    // Indicating that data has been saved
                    MessageBox.Show("File saved successfully");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }

    public static void saveAs(ListView listView1)
    {
        // reusing Save button method
        hasBeenSaved = false;
        saveFileName = "";
        save(listView1);
    }

    public static void sortWords(bool byValue, bool ascending, ListView listView1)
    {
        IOrderedEnumerable<KeyValuePair<string, int>> sortedWords;

        if (byValue == true && ascending == true)
        {
            sortedWords = from entry in wordCollection orderby entry.Value ascending select entry;
        }
        else if (byValue == false && ascending == true)
        {
            sortedWords = from entry in wordCollection orderby entry.Key ascending select entry;
        }
        else if (byValue == true && ascending == false)
        {
            sortedWords = from entry in wordCollection orderby entry.Value descending select entry;
        }
        else /*if (byValue == false && ascending == false)*/
        {
            sortedWords = from entry in wordCollection orderby entry.Key descending select entry;
        }

        // Clearing listView for new words
        listView1.Items.Clear();
        listView1.Update();
        listView1.Refresh();

        foreach (KeyValuePair<string, int> kvp in sortedWords)
        {
            var listElement = new ListViewItem(kvp.Key);
            var listSubElement = new ListViewItem.ListViewSubItem(listElement, kvp.Value.ToString());

            listElement.SubItems.Add(listSubElement);
            listView1.Items.Add(listElement);
        }
    }
}