using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deploy
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App(null);
            new DeployStack(app, "DeployStack", new StackProps());
            app.Synth();
        }
    }
}
