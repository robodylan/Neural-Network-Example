using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace GeneticAlgorithims
{
    class Organism
    {
        public int Age;
        public float Speed = 0f;
        public Color color;
        public int rotation;
        public Vector2f position;
        public float[] brain;
        public int Health = 150;
        public int FOV;
        public Organism(Vector2f position, float[] parentDNA, Color color)
        {
            this.brain = parentDNA;
            this.position = position;
            this.color = color;
        }

        public void Mutate()
        {
            for (int i = 0; i < brain.Length; i++)
            {
                if(Program.rand.Next(1,(20 - Program.a.mutationRate.Value)) == 8)brain[i] += Program.rand.Next(1, 100) / 1000;
            }
        }

        public Organism()
        {

        }

        public static float[] getOutput(float[] Input, float[] Weights)
        {
            int i = 0;
            float[] Output = new float[Input.Length];
            for (int a = 0; a < Input.Length; a++)
            {
                for (int b = a * Input.Length; b < (a * Input.Length) + Input.Length; b++)
                {
                    i++;
                    Output[a] += Input[a] * Weights[b] + Program.rand.Next(-1,1);
                } 
            }
            return Output;
        }
    }
}
