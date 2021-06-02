/**************************************************************************
 *                                                                        *
 *  Copyright:   (c) 2021,  Besliu Catalina, Nagit Tiberiu Stefan         *
 *  E-mail:      catalina.besliu@student.tuiasi.ro                        *
 *               tiberiu-stefan.nagit@student.tuiasi.ro                   *
 *  Description: MP3Player windows forms app                              *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class Form1 : Form
    {
        private OpenFileDialog _openFileDialog;
        public static Player.Player player;       // instanta modul Plyaer pentru a prelucra fisierele audio

        public Form1()
        {
            InitializeComponent();
            player = Player.Player.getInstance();   // utilizare singleton
            volume.Value = player.Volume;           // initializare volum audio
        }

        // eveniment modificare bara de volum
        private void volume_Scroll(object sender, EventArgs e)
        {
            audioPlayer.settings.volume = volume.Value;     // modificare volum
            volLabel.Text = volume.Value.ToString() + "%";  // afisare putere volum in procente
        }

        // eveniment incarcare fisiere
        private void fileBtn_Click(object sender, EventArgs e)
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.Multiselect = true;         // posibilitate incarcare mai multe fisiere concomitent
            _openFileDialog.Filter = "MP3 Audio File (*.mp3)|*.mp3| Windows Media File (*.wma)|*.wma|WAV Audio File (*.wav)|*.wav|All Files (*.*)|*.*";
            if (_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (player.Paths == null)
                {
                    player.Paths = _openFileDialog.FileNames;   // incarcare nume fisiere
                    string[] temp = _openFileDialog.FileNames;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        string[] split = temp[i].Split('\\');
                        temp[i] = split[split.Length - 1];
                    }
                    player.Files = temp;   // incarcare pathuri
                    try
                    {
                        if (player.Files.Length < 0)
                            throw new Exception();              // se arunca o exceptie daca nu s-au putut incarca fisierele
                        for (int i = 0; i < player.Files.Length; ++i)
                        {
                            trackList.Items.Add(player.Files[i]);   // salvare in lista de redare a fisierelor audio incarcare
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Eroare la incarcare");
                    }
                }
                else
                {
                    player.Paths = player.Paths.Union(_openFileDialog.FileNames).ToArray();  // incarcare pathuri
                    string[] temp = _openFileDialog.FileNames;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        string[] split = temp[i].Split('\\');
                        temp[i] = split[split.Length - 1];
                    }
                    player.Files = player.Files.Union(temp).ToArray();   // incarcare nume fisiere
                    //for (int i = 0; i < player.Files.Length; i++)
                    //{
                    //    string[] split = player.Files[i].Split('\\');
                    //    player.Files[i] = split[split.Length - 1];
                    //}
                    
                    try
                    {
                        if (player.Files.Length < 0)
                            throw new Exception();              // se arunca o exceptie daca nu s-au putut incarca fisierele
                        trackList.Items.Clear();
                        for (int i = 0; i < player.Files.Length; ++i)
                        {
                            trackList.Items.Add(player.Files[i]);   // salvare in lista de redare a fisierelor audio incarcare
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Eroare la incarcare");
                    }

                }
            }
        }
        // eveniment schimbare fisier audio de redat prin selectarea din lista
        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                audioPlayer.URL = player.Paths[trackList.SelectedIndex];    // preluare cale catre fisierul selectat pentru redare
                audioPlayer.Ctlcontrols.play();     // redare audio 
            }
            catch
            {
                MessageBox.Show("Selectati un fisier");
            }
        }

        // eveniment reluare redare daca s-a folosit butonul de pauza
        private void playBtn_Click(object sender, EventArgs e)
        {
            audioPlayer.Ctlcontrols.play();
        }

        // eveniment de pauza a redarii
        private void button4_Click(object sender, EventArgs e)
        {
            audioPlayer.Ctlcontrols.pause();
        }
        // eveniment trecere la urmatorul fisier din lista
        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                trackList.SelectedIndex++;
                if (trackList.SelectedIndex > trackList.Items.Count)   // incrementare index, daca s-a ajuns la final se arunca o exceptie
                    throw new Exception();
            }
            catch 
            {
                MessageBox.Show("Ati ajuns la final");
            }
        }
        // eveniment trecere la fisierul anterior din lista
        private void prevBtn_Click(object sender, EventArgs e)
        {
            try
            {
                trackList.SelectedIndex--;
                if (trackList.SelectedIndex < 0)  // derementare index, daca s-a ajuns la inceput se arunca o exceptie
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ati ajuns la inceput");
            }

        }

        // timer pentru vizualizarea grafica in progressbar a timpului scurs din fisierul audio
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if(audioPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying) // se verifica daca este un fisier audio redat 
            {
                progressBar.Maximum = (int)audioPlayer.Ctlcontrols.currentItem.duration; // valoarea maxima a progress bar este durata totala a fisierului 
                progressBar.Value = (int)audioPlayer.Ctlcontrols.currentPosition; // valoarea curenta a progress bar este timpul scurs pana la acel moment 
                int minute = (int)audioPlayer.Ctlcontrols.currentPosition / 60;
                int restSecunde = (int)audioPlayer.Ctlcontrols.currentPosition % 60;
                labelDuration.Text = minute.ToString() + ":" + restSecunde.ToString();
                if (progressBar.Value == progressBar.Maximum)
                {
                    if (trackList.SelectedIndex < trackList.Items.Count - 1) // daca s-a ajuns la finalul fisierului audio si nu este ultimul din lista se trece la urmatorul
                        trackList.SelectedIndex++;
                }
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
        }
        // trecerea la o anumita sectiune a fisierlui audio prin evenimentul de click in interiorul progress bar 
        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (trackList.SelectedIndex != -1)
            {
                audioPlayer.Ctlcontrols.currentPosition = audioPlayer.currentMedia.duration * e.X / progressBar.Width;  // actualizare redare fisier audio de la pozitia selectata 
            }

        }
        //stergere a unui fisier selectat din lista de redare
        private void deleteSongBtn_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex != -1)//daca exista un fisier selectat se va trata pe cazuri,daca e ultimul sau nu
            {
                try
                {
                    int index = trackList.SelectedIndex;
                   
                    if (trackList.SelectedIndex == trackList.Items.Count-1)
                    {
                        trackList.Items.RemoveAt(trackList.SelectedIndex);
                        audioPlayer.currentPlaylist.clear();//va sterge fisierul si din audioPlayer
                    }
                    else
                    {
                        //se opreste fisierul curent, si se reda urmatorul
                        audioPlayer.currentPlaylist.clear();
                        nextBtn_Click(sender, e);
                        trackList.Items.RemoveAt(trackList.SelectedIndex - 1);
                    }
                    List<string> lista = player.Files.ToList();
                    lista.RemoveAt(index);
                    player.Files = lista.ToArray();

                    List<string> lista2 = player.Paths.ToList();
                    lista2.RemoveAt(index);
                    player.Paths = lista2.ToArray();
                }
                catch
                {
                    //audioPlayer.currentPlaylist.clear();
                    trackList.Items.Clear();
                    List<string> lista = player.Files.ToList();
                    lista.Clear();
                    player.Files = lista.ToArray();
                    player.Paths = lista.ToArray();

                    MessageBox.Show("Ati sters toate melodiile");
                }
                
            }
        }
        //stergere playlist din lista de redare
        private void deletePlaylistBtn_Click(object sender, EventArgs e)
        {
            if (trackList.Items.Count!=0)//daca sunt fisiere audio in lista se va sterge tot 
            {
                trackList.Items.Clear();
                List<string> lista = player.Files.ToList();
                lista.Clear();
                player.Files = lista.ToArray();
                player.Paths = lista.ToArray();

                audioPlayer.currentPlaylist.clear();
            }
            
        }
        //afisare help
        private void helpBtn_Click(object sender, EventArgs e)
        {
            String path = System.IO.Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(path + "/Mp3PlayerHelp.chm");//afisare fisier help
        }
    }
}
