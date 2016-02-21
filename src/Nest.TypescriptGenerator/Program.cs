using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TypeLite;
using TypeLite.Net4;

namespace Nest.TypescriptGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
	        var nestInterfaces = typeof (IRequest).Assembly
		        .GetTypes()
		        .Where(t => typeof(IRequest).IsAssignableFrom(t) || typeof(IResponse).IsAssignableFrom(t))
				.Where(t => t.IsClass)
		        .ToArray();

	        var definitions = nestInterfaces.Aggregate(TypeScript.Definitions(), (def, t) => def.For(t));

	        if (!Directory.Exists(@"c:\temp"))
	        {
		        Directory.CreateDirectory(@"c:\temp");
	        }

			File.WriteAllText(@"c:\temp\interfaces.ts", definitions.Generate());
        }
    }
}
