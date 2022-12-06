using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
namespace Dino.Classes
{
    public static class GameController
    {
        public static SoundPlayer soundplayer = new SoundPlayer(Properties.Resources.chimes);
        public static Image spritesheet=Properties.Resources.White_dino_sprite;
        public static List<Road> roads;
        public static List<Cactus> cactuses;
        public static List<Bird> birds;
        public static List<Sky> skys;
        
        public static SoundPlayer soundPlayer(SoundPlayer sound)
        {
            soundplayer = sound;
            return soundplayer;
        }
        public static int dangerSpawn = 5;
        public static int countDangerSpawn = 0;
        public static Image Img(Image image)
        {
            spritesheet = image;
            return spritesheet;
        }

        public static void Init()
        {
            roads = new List<Road>();
            birds = new List<Bird>();
            cactuses = new List<Cactus>();
            skys = new List<Sky>();
            GenerateRoad();
        }
        public static void MoveMap()
        {
     
            for (int i = 0; i < roads.Count; i++)
            {
                roads[i].transform.position.X -= 4;
                if (roads[i].transform.position.X + roads[i].transform.size.Width < 0)
                {
                    roads.RemoveAt(i);
                    GetNewRoad();
                }
            }
            for (int i = 0; i < cactuses.Count; i++)
            {
                cactuses[i].transform.position.X -=4;
                if (cactuses[i].transform.position.X + cactuses[i].transform.size.Width < 0)
                {
                    cactuses.RemoveAt(i);
                }
            }
            for (int i = 0; i < birds.Count; i++)
            {
                birds[i].transform.position.X -= 4;
                if (birds[i].transform.position.X + birds[i].transform.size.Width < 0)
                {
                    birds.RemoveAt(i);
                }
            }
            for (int i = 0; i < skys.Count; i++)
            {
                skys[i].transform.position.X -= 3;
                if (skys[i].transform.position.X + skys[i].transform.size.Width < 0)
                {
                    skys.RemoveAt(i);
                }
            }
        }

        public static void GetNewRoad()
        {
            Road road = new Road(new PointF(0 + 100 * 9, 200), new Size(100, 17));
            roads.Add(road);
            countDangerSpawn++;
            if (countDangerSpawn >= dangerSpawn)
            {
                Random r = new Random();
                dangerSpawn = r.Next(5, 6);
                countDangerSpawn = 0;
                int obj = r.Next(0, 2);
                switch (obj)
                {
                    case 0:
                        Cactus cactus = new Cactus(new PointF(0 + 100 * 9, 160), new Size(50, 50));
                        cactuses.Add(cactus);
                        break;
                    case 1:
                            int obj2 = r.Next(0, 3);
                            switch (obj2)
                            {
                                case 0:
                                    Bird bird = new Bird(new PointF(0 + 100 * 9, 120), new Size(50, 50));
                                    birds.Add(bird);
                                    break;
                                case 1:
                                    Bird birdh = new Bird(new PointF(0 + 100 * 9, 150), new Size(50, 50));
                                    birds.Add(birdh);
                                    break;
                                case 2:
                                    Bird birdhs = new Bird(new PointF(0 + 100 * 9, 90), new Size(50, 50));
                                    birds.Add(birdhs);
                                    break;
                            }
                        break;
                }
                int obj_sky = r.Next(0, 3);

                switch(obj_sky)
                {
                    case 1:
                        Sky sky1 = new Sky(new PointF(0 + 100 * 9, 50), new Size(92, 28));
                        skys.Add(sky1);
                        break;
                    case 2:
                        Sky sky2 = new Sky(new PointF(0 + 100 * 9, 70), new Size(92, 28));
                        skys.Add(sky2);
                        break;
                    case 3:
                        Sky sky3 = new Sky(new PointF(0 + 100 * 9, 120), new Size(92, 28));
                        skys.Add(sky3);
                        break;
                }
                
            }
        }
        public static void GenerateRoad()
        {
            for (int i = 0; i < 10; i++)
            {
                Road road = new Road(new PointF(0 + 100 * i, 200), new Size(110, 17));
                roads.Add(road);
                countDangerSpawn++;
            }
        }
        public static void DrawObjets(Graphics g)
        {
            for (int i = 0; i < roads.Count; i++)
            {
                roads[i].DrawSprite(g);
            }
            for (int i = 0; i < cactuses.Count; i++)
            {
                cactuses[i].DrawSprite(g);
            }
            for (int i = 0; i < birds.Count; i++)
            {
                birds[i].DrawSprite(g);
            }
            for (int i = 0; i < skys.Count; i++)
            {
                skys[i].DrawSprite(g);
            }
        }
    }
}
