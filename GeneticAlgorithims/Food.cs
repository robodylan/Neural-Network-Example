using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import SFML
using SFML.System;
using SFML.Graphics;
using SFML.Window;
namespace GeneticAlgorithims
{
    class Food
    {
        public Vector2f Position;
        public int Value;

        public Food(Vector2f Position, int Value)
        {
            this.Position = Position;
            this.Value = Value;
        }
    }
}
