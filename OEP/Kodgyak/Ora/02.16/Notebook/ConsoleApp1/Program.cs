using System;

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook nb = new Notebook(120, Notebook.Sort.Grid);
            Console.WriteLine($"Type of notebook: {nb.NotebookSort}.");
            Console.WriteLine($"Number of pages: {nb.PageCount()}, of which empty: {nb.EmptyCount()}");

            nb.WriteOnPage(8, "nyolcadik");
            nb.WriteOnPage(4, "negyedik");
            nb.WriteOnPage(42, "https://people.inf.elte.hu/gt/oep");
            nb.WriteOnPage(43, "hqu09s@inf.elte.hu");
            Console.WriteLine($"Page 42 contains \"{nb[42]}\".");

            Console.WriteLine("Tearing out Page 4.");
            nb.TearOut(4);

            Console.WriteLine($"Page 42 contains \"{nb[42]}\".");
            nb.TearOut(2);
            Console.WriteLine($"Number of pages: {nb.PageCount()}, of which empty: {nb.EmptyCount()}");

            var res = nb.Search();
            if (res.found)
            {
                Console.WriteLine($"Found empty page at {res.ind}.");
                nb.WriteOnPage(res.ind, "ijfalwcnlaksuichq38hdf9AWLFVNELKYJFNHESLDKJVHNYSKDJlkjnbslkjegvnslkdjv" +
                                        "asdawmcpoiqwjoifafcuh3lfjldeisvloiejgw49pt9wséGDkjsÉVOIDJvéLSDKVJsldff" +
                                        "amcpoiwajcoiNCOPINoPINOpiNpoiNPOiNPoiNOGInáepyvojdvdsjfalskncksncalkss");
            }
            else
            {
                Console.WriteLine("Notebook is full.");
            }

            Console.WriteLine($"Page 1 contains \"{nb[1]}\".");

            Console.WriteLine($"Number of pages: {nb.PageCount()}, of which empty: {nb.EmptyCount()}");

            Console.WriteLine("Tearing out every single empty page.");
            res = nb.Search();
            while (res.found)
            {
                nb.TearOut(res.ind);
                res = nb.Search();
            }

            res = nb.Search();
            if (res.found)
            {
                Console.WriteLine($"Found empty page at {res.ind}.");
                nb.WriteOnPage(res.ind, "impossible");
            }
            else
            {
                Console.WriteLine("Notebook is full.");
            }

            Console.WriteLine($"Number of pages: {nb.PageCount()}, of which empty: {nb.EmptyCount()}");

            // Console.WriteLine($"Page 42 contains \"{nb[42]}\".");
        }
    }
}
