using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14_homework
{
    class Garage : IGarage
    {
        public Car[] Cars { get; set; }
        public string[] CarTypes { get; set; }
        //public Car[] CanFixCar { get; set; }


        public Garage(string[] carTypes, int amountofcars )
        {
            CarTypes = carTypes;
            Cars = new Car[amountofcars];
        }

        //public Garage(Car[] cars)
        //{
        //    int index = 0;
        //    for (int i = 0; i < Cars.Length; i++)
        //    {
        //        if (!cars[i].TotalLost)
        //        {
        //            CanFixCar[index] = cars[i];
        //            index++;
        //        }
        //    }
        public void AddCar(Car car)
        {
            try
            {
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (car == Cars[i])
                    {
                        throw new CarAlreadyHereException();
                    }
                    else if (car.TotalLost)
                    {
                        throw new WeDoNotFixTotalLostException();
                    }
                    else if (!car.NeedsRepair)
                    {
                        throw new RepairMismatchException();
                    }
                    for (int j = 0; j < CarTypes.Length; j++)//3
                    {
                        if (car.Brand == CarTypes[j])
                        {
                            break;
                        }
                        else if (car.Brand != CarTypes[j] && j == CarTypes.Length-1)
                        {
                            throw new WrongGarageException();
                        }
                    }
                }
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (Cars[i] == null)
                    {
                        Cars[i] = car;
                        break;
                    }
                }
                Console.WriteLine("the car added succesfuly");
                
                 

            }
            catch (CarAlreadyHereException)
            {

                Console.WriteLine("car is already her..");
            }
            catch (WeDoNotFixTotalLostException)
            {
                Console.WriteLine("we cant fix this go awayy");
            }
            catch (WrongGarageException)
            {
                Console.WriteLine("we not fix car like this in here");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("is this a car?");
            }
            catch (RepairMismatchException)
            {
                Console.WriteLine("the car is already fix");
            }

        }

        public void FixCar()
        {
            Console.WriteLine("fixed");
        }

        public void TakeOutCar()
        {
            Console.WriteLine("get out of here");
        }
    }
}


