using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import SFML
using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace GeneticAlgorithims
{
    class Program
    {
        //Neural Network Variables
        public static int Inputs = 4;
        public static int Outputs = 4;
        public static int Hiddens = 2;
        public static int totalFrames = 0;
        public static int mouseSpawn = 0;
        //End Variables
        public static List<Organism> foods = new List<Organism>();
        public static Random rand = new Random();
        public static List<Organism> organisms = new List<Organism>();
        public static RenderWindow window = new RenderWindow(new VideoMode(512,512), "Neural Networks", Styles.Resize, new ContextSettings(512, 512, 16));

        public static Settings a = new Settings();
        static void Main(string[] args)
        {
            //Set position of console
            Console.WindowLeft = 0;
            Console.WindowTop = 0;
            //Set position of render window
            window.Position = new Vector2i(0,0);
            //Start Settings Window
            a.Visible = true;
            a.Show();
            //window.SetFramerateLimit(30);
            Generate();
            while(window.IsOpen && !Keyboard.IsKeyPressed(Keyboard.Key.Escape))
            {
                window.DispatchEvents();
                Update();
                if (totalFrames % (a.simSpeed.Value + 1)== 0 || Keyboard.IsKeyPressed(Keyboard.Key.N)) if (!Keyboard.IsKeyPressed(Keyboard.Key.T)) Clear();
                if (totalFrames % (a.simSpeed.Value + 1)== 0 || Keyboard.IsKeyPressed(Keyboard.Key.N)) Draw();
                window.Display();
                totalFrames++;
                if (mouseSpawn > -1) mouseSpawn--;
                if (Mouse.IsButtonPressed(Mouse.Button.Left) && mouseSpawn < 0 && 0 < Mouse.GetPosition(window).X && Mouse.GetPosition(window).X < window.Size.X)
                {
                    float[] randBrain = new float[16];
                    for (int i = 0; i < randBrain.Length; i++)
                    {
                        randBrain[i] = (float)rand.NextDouble() * rand.Next(-1, 2);
                    }
                    organisms.Add(new Organism(new Vector2f(Mouse.GetPosition(window).X, Mouse.GetPosition(window).Y), randBrain, new Color((byte)rand.Next(0, 128), (byte)rand.Next(0, 128), (byte)rand.Next(0, 128))));

                    mouseSpawn = 100;
                }
                if (Mouse.IsButtonPressed(Mouse.Button.Right) && 0 < Mouse.GetPosition(window).X && Mouse.GetPosition(window).X < window.Size.X)
                {
                   
                    foods.Add(new Organism(new Vector2f(Mouse.GetPosition(window).X, Mouse.GetPosition(window).Y), new float[16], new Color((byte)rand.Next(0, 128), (byte)rand.Next(0, 128), (byte)rand.Next(0, 128))));

                    mouseSpawn = 10;
                }
            }
        }

        static void Generate()
        {
            for (int x = 0; x < 4000; x++)
            {
                organisms.Add(new Organism(new Vector2f(rand.Next(0, (int)window.Size.X), rand.Next(0, (int)window.Size.Y)), new float[16], new Color((byte)rand.Next(0, 128), (byte)rand.Next(0, 128), (byte)rand.Next(0, 128))));
            }
            foreach (Organism organism in organisms)
            {
                float[] randBrain = new float[16];
                for (int i = 0; i < randBrain.Length;i++)
                {
                    randBrain[i] = (float)rand.NextDouble() * rand.Next(-1, 2);
                }
                organism.brain = randBrain;
                //organism.rotation = rand.Next(1, 360);
            }
        }

        static void Update()
        {
            for(int B = 0; B < a.foodRate.Value; B++) foods.Add(new Organism(new Vector2f(rand.Next(0, (int)window.Size.X), rand.Next(0, (int)window.Size.Y)), new float[] { 0, 0, 0, 0 }, Color.White));
            //Image map = window.Capture();
            List<Organism> toDie = new List<Organism>();
            List<Organism> toSpawn = new List<Organism>();
            List<Organism> eaten = new List<Organism>();
            foreach(Organism organism in organisms)
            {
                //Console.Beep(organism.rotation + 37, 10);
                //Get Near Organism
                Organism near = new Organism();
                foreach (Organism check in foods)
                {
                    if (check != organism)
                    {
                        int Distance = getDistance(check.position, organism.position);
                        if (Distance < 320)
                        {
                            near = check;
                            if (Distance < 16)
                            {
                                eaten.Add(near);
                                organism.Health += 20;
                            }
                        }
                    }
                }
                /*Begin Neural Network*/
                //Get Inputs
                float[] Input = new float[4];
                Input[0] = (near.color.G > 0) ? 1:0;
                Input[1] = (near.position != null) ? Math.Abs(near.position.X - organism.position.X) : 0;
                Input[2] = (near.position != null) ? Math.Abs(near.position.Y - organism.position.Y) : 0;
                Input[3] = organism.Health;
                //Get Outputs
                float[] Output = Organism.getOutput(Input, organism.brain);
                //Apply Outputs
                organism.rotation += (int)Output[0] / 20;
                organism.rotation -= (int)Output[1] / 20;
                organism.Speed = Output[2] / 100;
                /*End Neural Network*/
                organism.Age++; //Make it one cycle older
                organism.Health --;
         

                float X = organism.position.X;
                float Y = organism.position.Y;
                if (organism.position.X > window.Size.X) organism.position.X = 0;
                if (organism.position.X < 0) organism.position.X = window.Size.X;
                if (organism.position.Y > window.Size.Y) organism.position.Y = 0;
                if (organism.position.Y < 0) organism.position.Y = window.Size.Y;

                //Console.WriteLine("{0},{1}",organism.Age, organism.position.X);

                if(organism.Age % 155 + rand.Next(-5,5) == 0 && a.canRepo.Checked)
                {
                    Organism newOrganism = new Organism(organism.position, organism.brain, organism.color);
                    newOrganism.Mutate();
                    toSpawn.Add(newOrganism);
                }
                //Add Speed
                organism.position.X += 0.50f * organism.Speed * (float)Math.Cos(organism.rotation * 0.0174f);
                organism.position.Y += 0.50f * organism.Speed * (float)Math.Sin(organism.rotation * 0.0174f); 
                if (organism.Health < 0)
                {
                    if(a.canDie.Checked) toDie.Add(organism);
                }
            }
            foreach (Organism die in toDie) { organisms.Remove(die); }
            foreach (Organism eat in eaten) { foods.Remove(eat); }
            organisms.AddRange(toSpawn);
            toDie.Clear();
            toSpawn.Clear();
            eaten.Clear();
        }

        static void Draw()
        {

            Sprite bufferSpriteA = new Sprite(new Texture("food.bmp"));
            foreach (Organism food in foods)
            {
                bufferSpriteA.Position = food.position;
                window.Draw(bufferSpriteA);
            }
            Sprite bufferSprite = new Sprite(new Texture("img.png"));
            foreach (Organism organism in organisms)
            {

                /*Vertex[] line = new Vertex[2];
                line[0] = new Vertex(organism.position, Color.Red);
                line[1] = new Vertex(new Vector2f(organism.position.X + (float)(120 * Math.Cos((organism.rotation - 30) * 0.0174)), organism.position.Y + (float)(120 * Math.Sin((organism.rotation - 30) * 0.0174))), Color.Red);
                window.Draw(line, PrimitiveType.Lines);

                line[0] = new Vertex(organism.position, Color.Red);
                line[1] = new Vertex(new Vector2f(organism.position.X + (float)(120 * Math.Cos((organism.rotation + 30) * 0.0174)), organism.position.Y + (float)(120 * Math.Sin((organism.rotation + 30) * 0.0174))), Color.Red);
                window.Draw(line, PrimitiveType.Lines);*/

                bufferSprite.Origin = new Vector2f(8, 8);
                bufferSprite.Color = organism.color;
                bufferSprite.Rotation = organism.rotation;
                bufferSprite.Position = organism.position;
                window.Draw(bufferSprite);

            }
        }

        static int getDistance(Vector2f A, Vector2f B)
        {
            return (int)Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        static void Clear()
        {
            RectangleShape rect = new RectangleShape(new Vector2f(window.Size.X, window.Size.Y));
            rect.FillColor = new Color(245,78,45, (byte)(255 - ((a.traceLength.Value - 100)*20)));
            window.Draw(rect);
        }
    }
}
