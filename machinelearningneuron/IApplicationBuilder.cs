using System;
using System.Threading.Tasks;

namespace machinelearningneuron
{
    public interface IApplicationBuilder
    {
        void UseDeveloperExceptionPage();
        void Run(Func<object, Task> p);
    }
}