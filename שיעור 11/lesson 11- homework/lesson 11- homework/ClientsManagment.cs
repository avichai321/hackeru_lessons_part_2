using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11__homework
{
    public class ClientsManagment
    {
        private string[] clientsNames = new string[10];
        private int[] clientsAges = new int[10];
        private bool[] clientsVegeterian = new bool[10];
        private int clientsCounter;

        public ClientsManagment(string[] clientsNames, int[] clientsAges, bool[] clientsVegeterian, int clientsCounter)
        {
            this.clientsNames = clientsNames;
            this.clientsAges = clientsAges;
            this.clientsVegeterian = clientsVegeterian;
            this.clientsCounter = clientsCounter;
        }
        private void AddNewNameToList(string newName)
        {
            for (int i = 0; i < clientsCounter; i++)
            {
                if (string.IsNullOrEmpty(clientsNames[i])&&string.IsNullOrEmpty(newName))
                {
                    clientsNames[i] = newName;
                    break;
                }
            }

        }
        private void AddNewAgeToList(int newAge)
        {
            for (int i = 0; i <clientsCounter; i++)
            {
                if (clientsAges[i] == 0&& newAge>18)
                {
                    clientsAges[i] = newAge;
                    break;
                }
            }
        }
        private void AddNewBoolToList(bool isVegetarian)
        {
            for (int i = 0; i < clientsCounter; i++)
            {
                if (clientsVegeterian[i] != isVegetarian)
                {
                    clientsVegeterian[i] = isVegetarian;
                    break;
                }
            }
        }
        public string GetName(int index)
        {
            return clientsNames[index - 1];
        }
        public int GetAge(int index)
        {
            return clientsAges[index - 1];
        }
        public bool GetIfIsVeg(int index)
        {
            return clientsVegeterian[index - 1];
        }
        public void AddNewClient(string newName, int newAge, bool isVegetarian)
        {
            AddNewNameToList(newName);
            AddNewAgeToList(newAge);
            AddNewBoolToList(isVegetarian);
        }
    }
}
