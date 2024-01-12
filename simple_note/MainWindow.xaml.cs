using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace simple_note
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string originaNotetext = "";
        List<Note> notes = new List<Note>();
        List<NoteText> noteTexts = new List<NoteText>();
        

        public MainWindow()
        {
            InitializeComponent();
                        
        }

        private void ButtonNewNote_Click(object sender, RoutedEventArgs e)
        {            
            if (textBoxNoteName.Visibility == Visibility.Hidden)
            {
                textBoxNoteName.Visibility = Visibility.Visible;
                return;
            }

            listBoxNoteList.SelectedIndex = -1;


            if (textBoxNoteName.Text == "New note")
            {
                return;
            }
            

            var note = new Note(textBoxNoteName.Text);
            notes.Add(note);          
            listBoxNoteList.Items.Add(note);

            var note_text = new NoteText(textBoxNote.Text);
            noteTexts.Add(note_text);

            textBoxNoteName.Visibility = Visibility.Hidden;
            textBoxNoteName.Text = "New note";            
        }

        private void TextBoxNoteName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxNoteList.SelectedIndex != -1)
            {
                // nosaka list kā
                textBoxNote.Text = noteTexts[listBoxNoteList.SelectedIndex].ToString();
                //= notes[listBoxNoteList.SelectedIndex].NoteText;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listBoxNoteList.SelectedIndex != -1)
            {
                int selectedIndex = listBoxNoteList.SelectedIndex;
                noteTexts[selectedIndex] = new NoteText(textBoxNote.Text);
            }
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxNoteName_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void textBoxNoteName_LostFocus(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
