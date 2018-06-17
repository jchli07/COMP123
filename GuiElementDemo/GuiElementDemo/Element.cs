using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiElementDemo
{
    class Element
    {
        public string name;
        public string symbol;
        public int proton;
        public int neutron;
        public double weight;

        public Element(string name, int proton, int neutron, double weight, string symbol)
        {
            this.name = name;
            this.symbol = symbol;
            this.proton = proton;
            this.neutron = neutron;
            this.weight = weight;
        }

        public Element()
        { }

        public static Element Parse(string line)
        {
            string[] xline = line.Split(' ');

            if (xline.Length > 5)
                throw new Exception("ERROR: Not enough variables!");

            Element a = new Element();

            string newname = xline[0];
            int newproton = Convert.ToInt32(xline[1]);
            int newneutron = Convert.ToInt32(xline[2]);
            double newweight = Convert.ToDouble(xline[3]);
            string newsym = xline[4];

            return a;
        }

        public static List<Element> GetElements()
        {
            List<Element> elements = new List<Element>();
            elements.Add(Element.Parse("Hydrogen 1 0 1.0079 H"));
            elements.Add(Element.Parse("Helium 2 2 4.0026 He")); ;
            elements.Add(Element.Parse("Lithium 3 4 6.941 Li")); ;
            elements.Add(Element.Parse("Beryllium 4 5 9.0122 Be"));
            elements.Add(Element.Parse("Boron 5 6 10.811 B"));
            elements.Add(Element.Parse("Carbon 6 6 12.0107 C"));
            elements.Add(Element.Parse("Nitrogen 7 7 14.0067 N"));
            elements.Add(Element.Parse("Oxygen 8 8 15.9994 O"));
            elements.Add(Element.Parse("Fluorine 9 10 18.9984 F"));
            elements.Add(Element.Parse("Neon 10 10 20.1797 Ne"));
            elements.Add(Element.Parse("Sodium 11 12 22.9897 Na"));
            elements.Add(Element.Parse("Magnesium 12 12 24.305 Mg"));
            elements.Add(Element.Parse("Aluminum 13 14 26.9815 Al"));
            elements.Add(Element.Parse("Silicon 14 14 28.0855 Si"));
            elements.Add(Element.Parse("Phosphorus 15 16 30.9738 P"));
            elements.Add(Element.Parse("Sulfur 16 16 32.065 S"));
            elements.Add(Element.Parse("Chlorine 17 18 35.453 Cl"));
            elements.Add(Element.Parse("Potassium 19 20 39.0983 K"));
            elements.Add(Element.Parse("Argon 18 22 39.948 Ar"));
            elements.Add(Element.Parse("Calcium 20 20 40.078 Ca"));
            elements.Add(Element.Parse("Scandium 21 24 44.9559 Sc"));
            elements.Add(Element.Parse("Titanium 22 26 47.867 Ti"));
            elements.Add(Element.Parse("Vanadium 23 28 50.9415 V"));
            elements.Add(Element.Parse("Chromium 24 28 51.9961 Cr"));
            elements.Add(Element.Parse("Manganese 25 30 54.938 Mn"));
            elements.Add(Element.Parse("Iron 26 30 55.845 Fe"));
            elements.Add(Element.Parse("Nickel 28 31 58.6934 Ni"));
            elements.Add(Element.Parse("Cobalt 27 32 58.9332 Co"));
            elements.Add(Element.Parse("Copper 29 35 63.546 Cu"));
            elements.Add(Element.Parse("Zinc 30 35 65.39 Zn"));
            elements.Add(Element.Parse("Gallium 31 39 69.723 Ga"));
            elements.Add(Element.Parse("Germanium 32 41 72.64 Ge"));
            elements.Add(Element.Parse("Arsenic 33 42 74.9216 As"));
            elements.Add(Element.Parse("Selenium 34 45 78.96 Se"));
            elements.Add(Element.Parse("Bromine 35 45 79.904 Br"));
            elements.Add(Element.Parse("Krypton 36 48 83.8 Kr"));
            elements.Add(Element.Parse("Rubidium 37 48 85.4678 Rb"));
            elements.Add(Element.Parse("Strontium 38 50 87.62 Sr"));
            elements.Add(Element.Parse("Yttrium 39 50 88.9059 Y"));
            elements.Add(Element.Parse("Zirconium 40 51 91.224 Zr"));
            elements.Add(Element.Parse("Niobium 41 52 92.9064 Nb"));
            elements.Add(Element.Parse("Molybdenum 42 54 95.94 Mo"));
            elements.Add(Element.Parse("Technetium 43 55 98 Tc"));
            elements.Add(Element.Parse("Ruthenium 44 57 101.07 Ru"));
            elements.Add(Element.Parse("Rhodium 45 58 102.9055 Rh"));
            elements.Add(Element.Parse("Palladium 46 60 106.42 Pd"));
            elements.Add(Element.Parse("Silver 47 61 107.8682 Ag"));
            elements.Add(Element.Parse("Cadmium 48 64 112.411 Cd"));
            elements.Add(Element.Parse("Indium 49 66 114.818 In"));
            elements.Add(Element.Parse("Tin 50 69 118.71 Sn"));
            elements.Add(Element.Parse("Antimony 51 71 121.76 Sb"));
            elements.Add(Element.Parse("Iodine 53 74 126.9045 I"));
            elements.Add(Element.Parse("Tellurium 52 76 127.6 Te"));
            elements.Add(Element.Parse("Xenon 54 77 131.293 Xe"));
            elements.Add(Element.Parse("Cesium 55 78 132.9055 Cs"));
            elements.Add(Element.Parse("Barium 56 81 137.327 Ba"));
            elements.Add(Element.Parse("Lanthanum 57 82 138.9055 La"));
            elements.Add(Element.Parse("Cerium 58 82 140.116 Ce"));
            elements.Add(Element.Parse("Praseodymium 59 82 140.9077 Pr"));
            elements.Add(Element.Parse("Neodymium 60 84 144.24 Nd"));
            elements.Add(Element.Parse("Promethium 61 84 145 Pm"));
            elements.Add(Element.Parse("Samarium 62 88 150.36 Sm"));
            elements.Add(Element.Parse("Europium 63 89 151.964 Eu"));
            elements.Add(Element.Parse("Gadolinium 64 93 157.25 Gd"));
            elements.Add(Element.Parse("Terbium 65 94 158.9253 Tb"));
            elements.Add(Element.Parse("Dysprosium 66 97 162.5 Dy"));
            elements.Add(Element.Parse("Holmium 67 98 164.9303 Ho"));
            elements.Add(Element.Parse("Erbium 68 99 167.259 Er"));
            elements.Add(Element.Parse("Thulium 69 100 168.9342 Tm"));
            elements.Add(Element.Parse("Ytterbium 70 103 173.04 Yb"));
            elements.Add(Element.Parse("Lutetium 71 104 174.967 Lu"));
            elements.Add(Element.Parse("Hafnium 72 106 178.49 Hf"));
            elements.Add(Element.Parse("Tantalum 73 108 180.9479 Ta"));
            elements.Add(Element.Parse("Tungsten 74 110 183.84 W"));
            elements.Add(Element.Parse("Rhenium 75 111 186.207 Re"));
            elements.Add(Element.Parse("Osmium 76 114 190.23 Os"));
            elements.Add(Element.Parse("Iridium 77 115 192.217 Ir"));
            elements.Add(Element.Parse("Platinum 78 117 195.078 Pt"));
            elements.Add(Element.Parse("Gold 79 118 196.9665 Au"));
            elements.Add(Element.Parse("Mercury 80 121 200.59 Hg"));
            elements.Add(Element.Parse("Thallium 81 123 204.3833 Tl"));
            elements.Add(Element.Parse("Lead 82 125 207.2 Pb"));
            elements.Add(Element.Parse("Bismuth 83 126 208.9804 Bi"));
            elements.Add(Element.Parse("Polonium 84 125 209 Po"));
            elements.Add(Element.Parse("Astatine 85 125 210 At"));
            elements.Add(Element.Parse("Radon 86 136 222 Rn"));
            elements.Add(Element.Parse("Francium 87 136 223 Fr"));
            elements.Add(Element.Parse("Radium 88 138 226 Ra"));
            elements.Add(Element.Parse("Actinium 89 138 227 Ac"));
            elements.Add(Element.Parse("Protactinium 91 140 231.0359 Pa"));
            elements.Add(Element.Parse("Thorium 90 142 232.0381 Th"));
            elements.Add(Element.Parse("Neptunium 93 144 237 Np"));
            elements.Add(Element.Parse("Uranium 92 146 238.0289 U"));
            elements.Add(Element.Parse("Americium 95 148 243 Am"));
            elements.Add(Element.Parse("Plutonium 94 150 244 Pu"));
            elements.Add(Element.Parse("Curium 96 151 247 Cm"));
            elements.Add(Element.Parse("Berkelium 97 150 247 Bk"));
            elements.Add(Element.Parse("Californium 98 153 251 Cf"));
            elements.Add(Element.Parse("Einsteinium 99 153 252 Es"));
            elements.Add(Element.Parse("Fermium 100 157 257 Fm"));
            elements.Add(Element.Parse("Mendelevium 101 157 258 Md"));
            elements.Add(Element.Parse("Nobelium 102 157 259 No"));
            elements.Add(Element.Parse("Rutherfordium 104 157 261 Rf"));
            elements.Add(Element.Parse("Lawrencium 103 159 262 Lr"));
            elements.Add(Element.Parse("Dubnium 105 157 262 Db"));
            elements.Add(Element.Parse("Bohrium 107 157 264 Bh"));
            elements.Add(Element.Parse("Seaborgium 106 160 266 Sg"));
            elements.Add(Element.Parse("Meitnerium 109 159 268 Mt"));
            elements.Add(Element.Parse("Roentgenium 111 161 272 Rg"));
            elements.Add(Element.Parse("Hassium 108 169 277 Hs"));

            return elements;
        }
    }
}
