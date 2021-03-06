﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo2App
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            RandomFunctionBox1 RFB = new RandomFunctionBox1();
        }
    }

    interface IColorable
    {
        string GetColor();
        void SetColor(string col);
    }

    interface ICountable
    {
        int GetCounter();
        void SetCounter(int n);
        void DoubleCounter();
    }

    interface IPageable
    {
        int Length();
        int CurrentPage();
        void GoToNextPage();
        void GoToFirstPage();
        void GoToPreviousPage();
    }

    interface IRandomFunctionBox : IColorable, ICountable
    {
        void DoSomethingNotSoRandom();
    }

    class RandomFunctionBox1 : IRandomFunctionBox
    {
        public static void Func01()
        {
            System.Console.WriteLine("Func01 Running");
        }

        public static void Func02()
        {
            System.Console.WriteLine("Func02 Running");
        }

        string Color;
        public void SetColor(string col)
        {
            Color = col;
        }
        public string GetColor()
        {
            return Color;
        }

        int Counter;
        public void DoubleCounter()
        {
            Counter *= 2;
        }
        public void SetCounter (int count)
        {
            Counter = count;
        }
        public int GetCounter()
        {
            return Counter;
        }
        public delegate int NumberReturner();
        public static int NumberFunction() { return 5; }

        private int _MagicNumber;
        public int MagicNumber
        {
            get { return _MagicNumber; }
            set
            {
                if (value > 100 || value < 0)
                {
                    _MagicNumber = 42;
                }
                else
                {
                    _MagicNumber = value;
                }
            }
        }
        public void DoSomethingNotSoRandom()
        {
            DoubleCounter();
        }
    }

    class RandomFunctionBox2 : IRandomFunctionBox
    {
        int Counter;
        public void DoubleCounter()
        {
            Counter *= 5;
        }
        public void SetCounter(int count)
        {
            Counter = count;
        }
        public int GetCounter()
        {
            return Counter;
        }

        string Color;
        public void SetColor(string col)
        {
            Color = col;
        }
        public string GetColor()
        {
            return Color;
        }
        public void DoSomethingNotSoRandom()
        {
            SetCounter(7);
        }
    }

    class Book : IColorable, IPageable
    {
        string Color;
        public void SetColor(string col)
        {
            Color = col;
        }
        public string GetColor()
        {
            return Color;
        }
        private string Title { get; set; }
        private string Author { get; set; }
        int _Length;
        public int Length()
        {
            return _Length;
        }
        int _CurrentPage;
        public int CurrentPage()
        {
            return _CurrentPage;
        }
        public void GoToNextPage()
        {
            if (_CurrentPage < _Length)
            {
                _CurrentPage++;
            }
        }
        public void GoToPreviousPage()
        {
            if (_CurrentPage > 0)
            {
                _CurrentPage--;
            }
        }
        public void GoToFirstPage()
        {
            _CurrentPage = 1;
        }
        bool BookHasBeenRead;
    }
}
