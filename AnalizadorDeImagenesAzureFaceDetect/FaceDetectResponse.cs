﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeImagenesAzureFaceDetect
{
    public class FaceDetectResponse
    {
        public string FaceId { get; set; }
        public FaceRectangle FaceRectangle { get; set; }
    }

    public class FaceRectangle
    {

        public int Height { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }

    }

   
}
