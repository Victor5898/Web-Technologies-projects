using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.Lessons
{
    public class Outline
    {
        public string Topic { get; set; }
        public string Time { get; set; }
        public LessonStatus Status { get; set; }
    }
}
