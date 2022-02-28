using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using LibVLCSharp.Shared;
using System.IO;
using System.Windows.Threading;

/*
 * Milestone 5 by Branden M.
 * CST-150
 * Grand Canyon University
 */


namespace Milestone_5
{
    public partial class Movie_Watching : Form
    {
        public LibVLC _libVLC;
        // This will allow us to access the VLC functions

        public MediaPlayer _mp;
        // This will allow us to access the video player function

        public Media media;
        // This will allow the use of media inside of the video player application

        public bool isPlaying = false;
        // This will check to see if the video is playing

        public Movie_Watching()
        {
            InitializeComponent();

            Core.Initialize();
            // This will allow the use of the VLC player becuase the windows form I'm using doesn't suppor windows media player

            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);

        }

        private void Movie_Watching_Load(object sender, EventArgs e)
        {
            // This will hold the elements to the video player
        }

        private void videoView1_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This will pause the video
            _mp.Pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This will quit the video
            _mp.Stop();
            Movie_Watching.ActiveForm.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will play movie number 1
            if (listBox1.SelectedIndex == 0)
            {
                var movie1 = (@"C:\Users\brand\source\repos\Milestone 5\sample movies\movie 1.mp4");
                // This will set the standard for the movie that will play

                _mp.Play(new Media(_libVLC, movie1));
                // This will utilize VLC to play movie 1

                isPlaying = true;
                // This will set the video to play
            }
            
            // This will play movie number 2
            else if (listBox1.SelectedIndex == 1)
            {
                var movie2 = (@"C:\Users\brand\source\repos\Milestone 5\sample movies\movie 2.mp4");
                // This will set the standard for the movie that will play

                _mp.Play(new Media(_libVLC, movie2));
                // This will utilize VLC to play movie 1

                isPlaying = true;
                // This will set the video to play
            }

            // This will play movie number 3
            else if (listBox1.SelectedIndex == 2)
            {
                var movie3 = (@"C:\Users\brand\source\repos\Milestone 5\sample movies\movie 3.mp4");
                // This will set the standard for the movie that will play

                _mp.Play(new Media(_libVLC, movie3));
                // This will utilize VLC to play movie 3

                isPlaying = true;
                // This will set the video to play
            }

            // This will play movie number 4
            else if (listBox1.SelectedIndex == 3)
            {
                var movie4 = (@"C:\Users\brand\source\repos\Milestone 5\sample movies\movie 4.mp4");
                // This will set the standard for the movie that will play

                _mp.Play(new Media(_libVLC, movie4));
                // This will utilize VLC to play movie 1

                isPlaying = true;
                // This will set the video to play
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This will tell the user to select the movie they would like to watch
        }
    }
        }
 

