using System;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace CommandLineParserDemo
{
    class Options
    {
        [Option('i', "input", Required = true, HelpText = "Input file to read.")]
        public string InputFile { get; set; }

        [Option("length", DefaultValue = -1, HelpText = "The maximum number of bytes to process.")]
        public int MaximumLength { get; set; }

        [Option('v', null, HelpText = "Print details during execution.")]
        public bool Verbose { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            // this without using CommandLine.Text
            //  or using HelpText.AutoBuild
            var usage = new StringBuilder();
            usage.AppendLine("Quickstart Application 1.0");
            usage.AppendLine("Read user manual for usage instructions...");
            return usage.ToString();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                // consume Options instance properties
                if (options.Verbose)
                {
                    Console.WriteLine(options.InputFile);
                    Console.WriteLine(options.MaximumLength);
                }
                else
                    Console.WriteLine("working ...");
            }
            else
            {
                // Display the default usage information
                Console.WriteLine(options.GetUsage());
            }

            Console.Read();
        }
    }
}
