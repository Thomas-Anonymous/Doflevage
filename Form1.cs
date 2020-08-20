using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doflevage {

    public enum Genre {
        male = 0,
        femelle = 1
    }
    public enum Stats {
        bas = 0,
        ok = 1,
        haut = 2
    }
    public enum Capacite {
        aucune = 0,
        precoce = 1,
        amoureuse = 2,
        endurante = 3,
        sage = 4,
        reproductrice = 5,
        porteuse = 6,
        infatiguable = 7,
        prediposeeGen = 8
    }
    public enum Parchemins {
        aucun = -1,
        dore = 0,

        pe_agi = 1,
        pe_cha = 2,
        pe_fo = 3,
        pe_int = 4,
        pe_sa = 5,
        pe_vita = 6,

        mo_agi = 7,
        mo_cha = 8,
        mo_fo = 9,
        mo_int = 10,
        mo_sa = 11,
        mo_vita = 12,

        gr_agi = 13,
        gr_cha = 14,
        gr_fo = 15,
        gr_int = 16,
        gr_sa = 17,
        gr_vita = 18,

        pui_agi = 19,
        pui_cha = 20,
        pui_fo = 21,
        pui_int = 22,
        pui_sa = 23,
        pui_vita = 24
    }
    public enum ChooseRace {
        inconnu = 0,
        armure = 1,
        plumes = 2,
        squelette = 3,
        rousse = 4,
        amande = 5,
        doree = 6,
        rousseamande = 7,
        roussedoree = 8,
        amandedoree = 9,
        indigo = 10,
        ebene = 11,
        rousseindigo = 12,
        rousseebene = 13,
        amandeindigo = 14,
        amandeebene = 15,
        doreeindigo = 16,
        doreeebene = 17,
        indigoebene = 18,
        pourpre = 19,
        orchidee = 20,
        pourprerousse = 21,
        orchideerousse = 22,
        amandepourpre = 23,
        amandeorchidee = 24,
        doreepourpre = 25,
        doreeorchidee = 26,
        indigopourpre = 27,
        indigoorchidee = 28,
        ebenepourpre = 29,
        ebeneorchidee = 30,
        pourpreorchidee = 31,
        ivoire = 32,
        turquoise = 33,
        ivoirerousse = 34,
        turquoiserousse = 35,
        amandeivoire = 36,
        amandeturquoise = 37,
        doreeivoire = 38,
        doreeturquoise = 39,
        indigoivoire = 40,
        indigoturquoise = 41,
        ebeneivoire = 42,
        ebeneturquoise = 43,
        pourpreivoire = 44,
        turquoisepourpre = 45,
        ivoireorchidee = 46,
        turquoiseorchidee = 47,
        ivoireturquoise = 48,
        emeraude = 49,
        prune = 50,
        rousseemeraude = 51,
        rousseprune = 52,
        amandeemeraude = 53,
        amandeprune = 54,
        doreeemeraude = 55,
        doreeprune = 56,
        indigoemeraude = 57,
        indigoprune = 58,
        ebeneemeraude = 59,
        ebeneprune = 60,
        pourpreemeraude = 61,
        pourpreprune = 62,
        orchideeemeraude = 63,
        orchideeprune = 64,
        ivoireemeraude = 65,
        ivoireprune = 66,
        turquoiseemeraude = 67,
        turquoiseprune = 68,
        emeraudeprune = 69
    }

    public partial class Form1 : Form {
        public List<String> encloList = new List<string>() {
            "Bonta",
            "Brâkmar",
            "Astrub"
        };

        public static Race races = new Race();

        public Form1() {
            InitializeComponent();

            // Update all lists
            list_race.BeginUpdate();
            list_mere.BeginUpdate();
            list_pere.BeginUpdate();
            list_sexe.BeginUpdate();
            list_capa.BeginUpdate();
            list_enclos.BeginUpdate();
            list_amour.BeginUpdate();
            list_maturite.BeginUpdate();
            list_endurance.BeginUpdate();

            foreach (ddType ddT in races.listType) {
                list_race.Items.Add(ddT.name);
                list_mere.Items.Add(ddT.name);
                list_pere.Items.Add(ddT.name);
            }
            foreach (int g in Enum.GetValues(typeof(Genre))) list_sexe.Items.Add(getSexe(g));
            foreach (int c in Enum.GetValues(typeof(Capacite))) list_capa.Items.Add(getCapcite(c));
            foreach (string e in encloList) list_enclos.Items.Add(e);
            foreach (int s in Enum.GetValues(typeof(Stats))) {
                list_amour.Items.Add(getStats(s));
                list_maturite.Items.Add(getStats(s));
                list_endurance.Items.Add(getStats(s));
            }

            list_race.SelectedIndex = 4;
            list_mere.SelectedIndex = 0;
            list_pere.SelectedIndex = 0;
            list_sexe.SelectedIndex = 0;
            list_capa.SelectedIndex = 0;
            list_enclos.SelectedIndex = 0;
            list_amour.SelectedIndex = 1;
            list_maturite.SelectedIndex = 1;
            list_endurance.SelectedIndex = 1;

            list_amour.EndUpdate();
            list_maturite.EndUpdate();
            list_endurance.EndUpdate();
            list_enclos.EndUpdate();
            list_capa.EndUpdate();
            list_sexe.EndUpdate();
            list_race.EndUpdate();
            list_mere.EndUpdate();
            list_pere.EndUpdate();

        }

        public void addEnclos(string nom) {
            if (!encloList.Contains(nom)) encloList.Add(nom); else MessageBox.Show("Vous ne pouvez pas avoir 2 enclos avec le même nom.", "Duplication de nom d'enclos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void removeEnclos(string nom) {
            if (!encloList.Contains(nom)) encloList.Remove(nom); else MessageBox.Show("Aucun enclos porte ce nom.", "Enclos inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public string getSexe(int genre) {
            switch (genre) {
                case 0:
                    return "mâle";
                case 1:
                    return "femelle";
                default:
                    return "null";
            }
        }

        public string getStats(int stats) {
            switch (stats) {
                case 0:
                    return "<";
                case 1:
                    return "ok";
                case 2:
                    return ">";
                default:
                    return "erreur";
            }
        }

        public string getCapcite(int capacite) {
            switch (capacite) {
                case 0:
                    return "Aucune";
                case 1:
                    return "Précoce";
                case 2:
                    return "Amoureuse";
                case 3:
                    return "Endurante";
                case 4:
                    return "Sage";
                case 5:
                    return "Reproductrice";
                case 6:
                    return "Porteuse";
                case 7:
                    return "Infatiguable";
                case 8:
                    return "Prédisposée Génétique";
                default:
                    return "erreur";
            }
        }
    }
}