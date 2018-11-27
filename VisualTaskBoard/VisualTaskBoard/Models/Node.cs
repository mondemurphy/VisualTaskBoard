using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualTaskBoard.Models
{
    public class Node
    {
        public int Id { get; set; }
        public bool Locked { get; set; }
        public string Text { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
