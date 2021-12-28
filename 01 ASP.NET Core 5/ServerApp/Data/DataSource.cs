using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data
{

        public class StarWarsMovie
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double RottenTomatoes { get; set; }
            public decimal Recaudation { get; set; }
            public DateTime? ReleaseDate { get; set; }
            public List<Character> Characters { get; set; } = new List<Character>();
        }

        public class Character
        {
            public int Id { get; set; }
            public int MovieId { get; set; }
            public string Name { get; set; }
            public string Species { get; set; }
            public string ExtraInfo { get; set; }
            public bool HasRemake { get; set; }
            public List<Teacher> Teachers = new List<Teacher>();
        };

        public class Teacher
        {
            public int Id { get; set; }
            public int CharacterId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

    }
