using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechStore
{
    internal class Supply
    {
        static double sells;
        List<Products> supplies = new List<Products>();

        public void MainMenu()
        {
            Console.Clear();
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("\x1b[38;5;201m[ What would you like to do? ]\x1b[0m\n\n" +
                    "1) Add an item\n" + //v
                    "2) Sell an item\n" + //v
                    "3) Show number of items from each category\n" + //v
                    "4) Show priciest item\n" + //v
                    "5) Show cheapest item\n" + //v
                    "6) Show revenue\n" + //v
                    "7) Details on an item\n" + //v
                    "8) List items by category\n" + //v
                    "\u001b[38;5;196m9) Exit\x1b[0m"); //v
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        SellItem();
                        break;
                    case 3:
                        CategoryNumbering();
                        break;
                    case 4:
                        Priciest();
                        break;
                    case 5:
                        Cheapest();
                        break;
                    case 6:
                        Console.Clear();
                        if (sells==0) Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Revenue is:" + sells);
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    case 7:
                        Search();
                        break;
                    case 8:
                        ListItemsByCategory();
                        break;
                    case 9:
                        menu = false;
                        break;
                }
            }
        }
        public void AddItem() // Game, Pheripheral, Hardware
        {
            Console.Clear();
            Console.WriteLine("Select type of item to add to the supply:\n1) game\n2) pheripheral\n3) hardware");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    AddGame();
                    break;
                case 2:
                    AddPheripheral();
                    break;
                case 3:
                    AddHardware();
                    break;
            }
        }
        public void SellItem() // Game, Pheripheral, Hardware
        {
            Console.Clear();
            Console.WriteLine("Select type of item to sell:\n1) game\n2) pheripheral\n3) hardware");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    SellGame();
                    break;
                case 2:
                    SellPeripheral();
                    break;
                case 3:
                    SellHardware();
                    break;
            }
        }

        #region game
        public void AddGame()
        {
            Console.Clear();
            Console.WriteLine("Enter genre,multiplayer support ,price, and name of the game");
            string genre = Console.ReadLine();
            bool multi = bool.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            supplies.Add(new Games(genre, multi, price, name));

            Console.WriteLine("\x1b[38;5;46mGame Added\x1b[0m");
            Console.ReadKey();
        }
        public void AddGame(string genre, bool multi, double price, string name)
        {
            supplies.Add(new Games(genre, multi, price, name));
        }
        public void SellGame()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the game to sell");
            string name = Console.ReadLine();

            var gameToRemove = supplies.OfType<Games>().FirstOrDefault(g => g.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));

            if (gameToRemove != null)
            {
                supplies.Remove(gameToRemove);
                Console.WriteLine("\x1b[38;5;226mGame sold, +" + gameToRemove.GetPrice() + "$\x1b[0m");
                sells += gameToRemove.GetPrice();
            }
            else
            {
                Console.WriteLine("\x1b[38;5;196mGame not found\x1b[0m");
            }
            Console.ReadKey();
        }
        #endregion

        #region peris
        public void SellPeripheral()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the peripheral to sell");
            string name = Console.ReadLine();

            var peripheralToRemove = supplies.OfType<Peripherals>().FirstOrDefault(p => p.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));

            if (peripheralToRemove != null)
            {
                supplies.Remove(peripheralToRemove);
                Console.WriteLine("\x1b[38;5;226m" + peripheralToRemove.GetCategory() + " sold, +" + peripheralToRemove.GetPrice() + "$\x1b[0m");
                sells += peripheralToRemove.GetPrice();
            }
            else
            {
                Console.WriteLine("\x1b[38;5;196mPeripheral not found\x1b[0m");
            }
            Console.ReadKey();
        }

        public void AddPheripheral()
        {
            Console.Clear();
            Console.WriteLine("What category do you want to add to?\n" +
                "1) Headphones\n" +
                "2) Monitors\n" +
                "3) Keyboards\n" +
                "4) Mice\n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    AddHeadphones();
                    break;
                case 2:
                    AddMonitor();
                    break;
                case 3:
                    AddKeyboard();
                    break;
                case 4:
                    AddMice();
                    break;
            }

        }

        public void AddHeadphones()
        {
            Console.Clear();
            Console.WriteLine("Enter wireless support,price and name");
            bool wireless = bool.Parse(Console.ReadLine());
            string category = "Headphones";
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            supplies.Add(new Headphones(wireless, category, price, name));

            Console.WriteLine("\x1b[38;5;46mItem Added\x1b[0m");
            Console.ReadKey();
        }
        public void AddMonitor()
        {
            Console.Clear();
            Console.WriteLine("Enter refresh rate (hz), size (inches), resolution, price, and name");
            int hz = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int resolution = int.Parse(Console.ReadLine());
            string category = "Monitors";
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            supplies.Add(new Monitors(hz, size, resolution, category, price, name));

            Console.WriteLine("\x1b[38;5;46mItem Added\x1b[0m");
            Console.ReadKey();
        }
        public void AddKeyboard()
        {
            Console.Clear();
            Console.WriteLine("Enter layout, wireless support, price, and name");
            string layout = Console.ReadLine();
            bool wireless = bool.Parse(Console.ReadLine());
            string category = "Keyboards";
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            supplies.Add(new Keyboards(layout, wireless, category, price, name));

            Console.WriteLine("\x1b[38;5;46mItem Added\x1b[0m");
            Console.ReadKey();
        }
        public void AddMice()
        {
            Console.Clear();
            Console.WriteLine("Enter polling rate, wireless support, price, and name");
            int polling = int.Parse(Console.ReadLine());
            bool wireless = bool.Parse(Console.ReadLine());
            string category = "Mice";
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            supplies.Add(new Mice(polling, wireless, category, price, name));

            Console.WriteLine("\x1b[38;5;46mItem Added\x1b[0m");
            Console.ReadKey();
        }

        #endregion

        #region hardware
        public void AddHardware()
        {
            Console.Clear();
            Console.WriteLine("What hardware do you want to add?\n" +
                "1) GPU\n" +
                "2) CPU\n" +
                "3) RAM\n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    AddGPU();
                    break;
                case 2:
                    AddCPU();
                    break;
                case 3:
                    AddRAM();
                    break;
            }
        }

        public void AddGPU()
        {
            Console.Clear();
            Console.WriteLine("Enter chipset, VRAM (GB), price, and name");
            string chipset = Console.ReadLine();
            int vram = int.Parse(Console.ReadLine());
            string type = "GPU";
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            supplies.Add(new GPUs(chipset, vram, type, price, name));

            Console.WriteLine("\x1b[38;5;46mGPU Added\x1b[0m");
            Console.ReadKey();
        }

        public void AddCPU()
        {
            Console.Clear();
            Console.WriteLine("Enter core count, frequency (GHz), price, and name");
            int cores = int.Parse(Console.ReadLine());
            double frequency = double.Parse(Console.ReadLine());
            string type = "CPU";
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            supplies.Add(new CPUs(cores, frequency, type, price, name));

            Console.WriteLine("\x1b[38;5;46mCPU Added\x1b[0m");
            Console.ReadKey();
        }

        public void AddRAM()
        {
            Console.Clear();
            Console.WriteLine("Enter capacity (GB), speed (MHz), price, and name");
            int capacity = int.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());
            string type = "RAM";
            double price = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            supplies.Add(new RAM(capacity, speed, type, price, name));

            Console.WriteLine("\x1b[38;5;46mRAM Added\x1b[0m");
            Console.ReadKey();
        }

        public void SellHardware()
        {
            Console.Clear();
            Console.WriteLine("What hardware do you want to sell?\n" +
                "1) GPU\n" +
                "2) CPU\n" +
                "3) RAM\n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    SellGPU();
                    break;
                case 2:
                    SellCPU();
                    break;
                case 3:
                    SellRAM();
                    break;
            }
        }

        public void SellGPU()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the GPU to sell");
            string name = Console.ReadLine();

            var gpuToRemove = supplies.OfType<GPUs>().FirstOrDefault(g => g.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));

            if (gpuToRemove != null)
            {
                supplies.Remove(gpuToRemove);
                Console.WriteLine("\x1b[38;5;226mGPU sold, +" + gpuToRemove.GetPrice() + "$\x1b[0m");
                sells += gpuToRemove.GetPrice();
            }
            else
            {
                Console.WriteLine("\x1b[38;5;196mGPU not found\x1b[0m");
            }
            Console.ReadKey();
        }

        public void SellCPU()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the CPU to sell");
            string name = Console.ReadLine();

            var cpuToRemove = supplies.OfType<CPUs>().FirstOrDefault(c => c.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));

            if (cpuToRemove != null)
            {
                supplies.Remove(cpuToRemove);
                Console.WriteLine("\x1b[38;5;226mCPU sold, +" + cpuToRemove.GetPrice() + "$\x1b[0m");
                sells += cpuToRemove.GetPrice();
            }
            else
            {
                Console.WriteLine("\x1b[38;5;196mCPU not found\x1b[0m");
            }
            Console.ReadKey();
        }

        public void SellRAM()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the RAM to sell");
            string name = Console.ReadLine();

            var ramToRemove = supplies.OfType<RAM>().FirstOrDefault(r => r.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));

            if (ramToRemove != null)
            {
                supplies.Remove(ramToRemove);
                Console.WriteLine("\x1b[38;5;226mRAM sold, +" + ramToRemove.GetPrice() + "$\x1b[0m");
                sells += ramToRemove.GetPrice();
            }
            else
            {
                Console.WriteLine("\x1b[38;5;196mRAM not found\x1b[0m");
            }
            Console.ReadKey();
        }

        #endregion

        #region other
        public void Priciest()
        {
            Console.Clear();
            if (supplies.Count == 0)
            {
                Console.WriteLine("\x1b[38;5;196mStock is empty\x1b[0");
                Console.ReadKey();
                return;
            }
            double price = 0;
            string name = "";
            string type = "";
            foreach (var item in supplies)
            {
                if (item.GetPrice() > price)
                {
                    price = item.GetPrice();
                    name = item.GetName();
                    type = item.GetType().Name;
                }
            }
            Console.WriteLine($"priciest item is \x1b[38;5;46m{name}\u001b[0m from the {type} category");
            Console.ReadKey();
        }
        public void Cheapest()
        {
            Console.Clear();
            if (supplies.Count == 0)
            {
                Console.WriteLine("\x1b[38;5;196mStock is empty\x1b[0");
                Console.ReadKey();
                return;
            }
            double price = supplies[0].GetPrice();
            string name = "";
            string type = "";

            foreach (var item in supplies)
            {
                if (item.GetPrice() <= price)
                {
                    price = item.GetPrice();
                    name = item.GetName();
                    type = item.GetType().Name;
                }
            }
            Console.WriteLine($"cheapest item is \u001b[38;5;46m{name}\u001b[0m from the {type} category");
            Console.ReadKey();
        }
        public void Search()
        {
            Console.Clear();
            Console.WriteLine("Search for an item by name:");
            string name = Console.ReadLine(); Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine((supplies.FirstOrDefault(i => i.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))).ToString());
            Console.ResetColor();
            Console.ReadKey();
        }
        public void CategoryNumbering()
        {
            Console.Clear();
            int games = 0, peripherals = 0, hardware = 0;
            foreach (var item in supplies.OfType<Games>())
            {
                games++;
            }
            foreach (var item in supplies.OfType<Peripherals>())
            {
                peripherals++;
            }
            foreach (var item in supplies.OfType<Hardware>())
            {
                hardware++;
            }

            Console.WriteLine($"\x1b[38;5;46mIn Stock:\x1b[0m \n{games} Games\n{peripherals} Peripheral equipment items\n{hardware} Hardware components");
            Console.ReadKey();
        }

        public void ListItemsByCategory()
        {
            Console.Clear();
            Console.WriteLine("Choose a category to list item names from:\n" +
                "1) Games\n" +
                "2) Peripherals\n" +
                "3) Hardware\n");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    ListGameNames();
                    break;
                case 2:
                    ListPeripheralNames();
                    break;
                case 3:
                    ListHardwareNames();
                    break;
                default:
                    Console.WriteLine("\x1b[38;5;196mInvalid choice.\x1b[0m");
                    break;
            }
            Console.ReadKey();
        }

        private void ListGameNames()
        {
            var games = supplies.OfType<Games>().ToList();
            if (games.Count == 0)
            {
                Console.WriteLine("\x1b[38;5;196mNo games in stock.\x1b[0m");
                return;
            }
            Console.WriteLine("\x1b[38;5;46mGames in stock:\x1b[0m");
            foreach (var game in games)
            {
                Console.WriteLine(game.GetName());
            }
        }

        private void ListPeripheralNames()
        {
            var peripherals = supplies.OfType<Peripherals>().ToList();
            if (peripherals.Count == 0)
            {
                Console.WriteLine("\x1b[38;5;196mNo peripherals in stock.\x1b[0m");
                return;
            }
            Console.WriteLine("\x1b[38;5;46mPeripherals in stock:\x1b[0m");
            foreach (var peripheral in peripherals)
            {
                Console.WriteLine(peripheral.GetName());
            }
        }

        private void ListHardwareNames()
        {
            var hardware = supplies.OfType<Hardware>().ToList();
            if (hardware.Count == 0)
            {
                Console.WriteLine("\x1b[38;5;196mNo hardware in stock.\x1b[0m");
                return;
            }
            Console.WriteLine("\x1b[38;5;46mHardware items in stock:\x1b[0m");
            foreach (var hw in hardware)
            {
                Console.WriteLine(hw.GetName());
            }
        }
        #endregion

        #region QA builders
        public void AddHeadphones(bool wireless, string category, double price, string name)
        {
            supplies.Add(new Headphones(wireless, category, price, name));
        }

        public void AddMonitor(int hz, double size, int resolution, string category, double price, string name)
        {
            supplies.Add(new Monitors(hz, size, resolution, category, price, name));
        }

        public void AddKeyboard(string layout, bool wireless, string category, double price, string name)
        {
            supplies.Add(new Keyboards(layout, wireless, category, price, name));
        }

        public void AddMice(int polling, bool wireless, string category, double price, string name)
        {
            supplies.Add(new Mice(polling, wireless, category, price, name));
        }

        public void AddGPU(string chipset, int vram, string type, double price, string name)
        {
            supplies.Add(new GPUs(chipset, vram, type, price, name));
        }

        public void AddCPU(int cores, double frequency, string type, double price, string name)
        {
            supplies.Add(new CPUs(cores, frequency, type, price, name));
        }

        public void AddRAM(int capacity, int speed, string type, double price, string name)
        {
            supplies.Add(new RAM(capacity, speed, type, price, name));
        }

        #endregion
    }
}
