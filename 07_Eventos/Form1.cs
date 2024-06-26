﻿using _07_Eventos.Lib;
using _07_Eventos.Lib.Mensageiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVideoEncode.Click+= EventoDeClick;
        }
        
        public void EventoDeClick(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video.mp4" };

            VideoEnconde vid = new VideoEnconde();

            vid.Encoded += new Email().EnviarMensagem;
            vid.Encoded += new SMS().EnviarMensagem;

            vid.Encode(video);
        }
    }
}
