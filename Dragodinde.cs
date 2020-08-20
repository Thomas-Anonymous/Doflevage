using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doflevage {

    public class Dragodinde {
        public string nom = "";
        public string pseudoProprio = "";

        public ChooseRace race = ChooseRace.inconnu;
        public Genre sexe = Genre.male;
        public int niveau = 0;
        public int reproActu = 0;
        public int reproMax = 0;

        public Stats amour = Stats.ok;
        public Stats maturite = Stats.ok;
        public Stats endurance = Stats.ok;

        public Capacite capacite = Capacite.aucune;
        public bool sauvage = false;
        public bool pure = false;
        public bool came = false;
        public bool ddAParcho = false;
        public bool feconde = false;

        public bool enEnclos = false;
        public string nomEnclos = "";

        public long tempsGesta = 0;

        public ChooseRace caractMere = ChooseRace.inconnu;
        public ChooseRace caractPere = ChooseRace.inconnu;


        public Dragodinde(string _nom, string _proprio, ChooseRace _race, Genre _sexe, int _niveau, int _reproActu, int _reproMax, Stats _amour, Stats _maturite, Stats _endurance, bool _sauvage, bool _pure, bool _came, bool _ddAParcho, bool _feconde, bool _enEnclos, string _nomEnclos, int _tempsGesta, ChooseRace mere, ChooseRace pere) {
            nom = _nom;
            pseudoProprio = _proprio;
            race = _race;
            sexe = _sexe;
            niveau = _niveau;
            reproActu = _reproActu;
            reproMax = _reproMax;
            amour = _amour;
            maturite = _maturite;
            endurance = _endurance;
            sauvage = _sauvage;
            pure = _pure;
            came = _came;
            ddAParcho = _ddAParcho;
            feconde = _feconde;
            enEnclos = _enEnclos;
            nomEnclos = _nomEnclos;
            tempsGesta = _tempsGesta;
            caractMere = mere;
            caractPere = pere;
        }
    }

}
