using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args) {

        }
    }

    class LoadBalancer
    {
        private static LoadBalancer instance = null;
        private List serverList = null;

        private LoadBalancer() {
            serverList = new Array();
        }
    }
}
