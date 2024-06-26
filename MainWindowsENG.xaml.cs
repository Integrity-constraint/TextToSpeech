﻿using System;
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
using System.Windows.Shapes;

namespace TextToSpeech
{
    /// <summary>
    /// Логика взаимодействия для MainWindowsENG.xaml
    /// </summary>
    public partial class MainWindowsENG : Window
    {
        public speech speech;
        public jsonHandler Json;
        public MainWindowsENG()
        {
            InitializeComponent();
            speech = new speech(cmdvoice);
            Json = new jsonHandler();
        }

        private void json(object sender, RoutedEventArgs e)
        {
            try
            {
                Json.savetoJson(text.Text, tb1.Text);
                MessageBox.Show($"The file has been saved as {tb1.Text}");
            }
            catch
            {
                MessageBox.Show($"an Error has occurd");
            }
        }

        private void voicer(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectedVoice = cmdvoice.SelectedItem.ToString();
                speech.SelectVoice(selectedVoice);
                speech.VoiceIt(text.Text);
            }
            catch
            {
                MessageBox.Show($"an Error has occurd");
            }

        }

        private void json_op(object sender, RoutedEventArgs e)
        {
            try
            {
                Json.openjson(text);
            }
            catch
            {
                MessageBox.Show($"возникла ошибка");
            }
        }
    }
}

