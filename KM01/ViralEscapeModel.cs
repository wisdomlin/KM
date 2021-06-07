using System;
using System.Collections.Generic;
using System.Text;

namespace KM01
{
    public class ViralEscapeModel
    {
        public string Predict(StructralPattern item)
        {
            if (item.Syntax == "correct" &&
                item.Semantics == "effectively different")
                return "viral escape";
            else
                return "no viral escape";
        }
    }
}
