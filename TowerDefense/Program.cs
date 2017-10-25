using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, create a map
            Map map = new Map(8, 5);

            // Second, TRY to create points for the path

            try
            {
                MapLocation pathPoint1 = new MapLocation(0, 3, map);
                MapLocation pathPoint2 = new MapLocation(1, 3, map);
                MapLocation pathPoint3 = new MapLocation(2, 3, map);
                MapLocation pathPoint4 = new MapLocation(3, 3, map);
                MapLocation pathPoint5 = new MapLocation(4, 3, map);
                MapLocation pathPoint6 = new MapLocation(5, 3, map);
                MapLocation pathPoint7 = new MapLocation(6, 3, map);
            }
            catch (OutOfBoundsException)
            {
                Console.WriteLine(ex.Message);
            }
            catch ()
            {
                Console.WriteLine("Unhandled TowerDefenceException");
            }
            catch ()
            {
                Console.WriteLine("Unhandled Exception");
            }

            Array arr = [pathPoint1, pathPoint2, pathPoint3, pathPoint4, pathPoint5, pathPoint6, pathPoint7];

            // arr.Each do |point|
            //     {
            //     map.OnMap(point);
            //     }

            Path path = new Path(arr);
        }
    }
}
