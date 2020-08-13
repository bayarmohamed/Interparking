using FilesLibrary.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLibrary
{
    public class Client
    {
        public string File { get; set; }
        private Strategy strategy;
        public void SetStrategy(Strategy Strategy)
        {
            this.strategy = Strategy;
            File = strategy.ApplyStrategy(File);

        }

    }
}
