using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doflevage {
    public class ddType {
        public int gen = 0;
        public string name = "";
        public ChooseRace chooseRace = ChooseRace.inconnu;
        public Parchemins parcho = Parchemins.aucun;
        public int tempsGestion = 0;

        public ddType(ChooseRace race) {
            chooseRace = race;

            switch (race) {
                case ChooseRace.inconnu:
                    parcho = Parchemins.aucun;
                    gen = 0;
                    tempsGestion = -1;
                    name = "inconnu";
                    break;
                case ChooseRace.armure:
                    parcho = Parchemins.aucun;
                    gen = -1;
                    tempsGestion = -1;
                    name = "Dragodinde en armure";
                    break;
                case ChooseRace.plumes:
                    parcho = Parchemins.aucun;
                    gen = -1;
                    tempsGestion = -1;
                    name = "Dragodinde à plumes";
                    break;
                case ChooseRace.squelette:
                    parcho = Parchemins.aucun;
                    gen = -1;
                    tempsGestion = -1;
                    name = "Dragodinde squelette";
                    break;
                case ChooseRace.rousse:
                    parcho = Parchemins.dore;
                    gen = 1;
                    tempsGestion = 48;
                    name = "Rousse";
                    break;
                case ChooseRace.amande:
                    parcho = Parchemins.dore;
                    gen = 1;
                    tempsGestion = 48;
                    name = "Amande";
                    break;
                case ChooseRace.doree:
                    parcho = Parchemins.dore;
                    gen = 1;
                    tempsGestion = 48;
                    name = "Dorée";
                    break;
                case ChooseRace.rousseamande:
                    parcho = Parchemins.pe_vita;
                    gen = 2;
                    tempsGestion = 60;
                    name = "Rousse Amande";
                    break;
                case ChooseRace.roussedoree:
                    parcho = Parchemins.pe_sa;
                    gen = 2;
                    tempsGestion = 60;
                    name = "Rousse Dorée";
                    break;
                case ChooseRace.amandedoree:
                    parcho = Parchemins.pe_sa;
                    gen = 2;
                    tempsGestion = 60;
                    name = "Amande Dorée";
                    break;
                case ChooseRace.indigo:
                    parcho = Parchemins.pe_cha;
                    gen = 3;
                    tempsGestion = 72;
                    name = "Indigo";
                    break;
                case ChooseRace.ebene:
                    parcho = Parchemins.pe_agi;
                    gen = 3;
                    tempsGestion = 72;
                    name = "Ebène";
                    break;
                case ChooseRace.rousseindigo:
                    parcho = Parchemins.pe_vita;
                    gen = 4;
                    tempsGestion = 84;
                    name = "Rousse Indigo";
                    break;
                case ChooseRace.rousseebene:
                    parcho = Parchemins.pe_vita;
                    gen = 4;
                    tempsGestion = 84;
                    name = "Rousse Ebène";
                    break;
                case ChooseRace.amandeindigo:
                    parcho = Parchemins.pe_cha;
                    gen = 4;
                    tempsGestion = 84;
                    name = "Amande Indigo";
                    break;
                case ChooseRace.amandeebene:
                    parcho = Parchemins.pe_agi;
                    gen = 4;
                    tempsGestion = 84;
                    name = "Amande Ebène";
                    break;
                case ChooseRace.doreeindigo:
                    parcho = Parchemins.pe_sa;
                    gen = 4;
                    tempsGestion = 84;
                    name = "Dorée Indigo";
                    break;
                case ChooseRace.doreeebene:
                    parcho = Parchemins.pe_sa;
                    gen = 4;
                    tempsGestion = 84;
                    name = "Dorée Ebène";
                    break;
                case ChooseRace.indigoebene:
                    parcho = Parchemins.pe_cha;
                    gen = 4;
                    tempsGestion = 84;
                    name = "Indigo Ebène";
                    break;
                case ChooseRace.pourpre:
                    parcho = Parchemins.pe_fo;
                    gen = 5;
                    tempsGestion = 96;
                    name = "Pourpre";
                    break;
                case ChooseRace.orchidee:
                    parcho = Parchemins.pe_int;
                    gen = 5;
                    tempsGestion = 96;
                    name = "Orchidée";
                    break;
                case ChooseRace.pourprerousse:
                    parcho = Parchemins.mo_fo;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Pourpre Rousse";
                    break;
                case ChooseRace.orchideerousse:
                    parcho = Parchemins.mo_int;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Orchidée Rousse";
                    break;
                case ChooseRace.amandepourpre:
                    parcho = Parchemins.mo_fo;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Amande Pourpre";
                    break;
                case ChooseRace.amandeorchidee:
                    parcho = Parchemins.mo_vita;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Amande Orchidée";
                    break;
                case ChooseRace.doreepourpre:
                    parcho = Parchemins.mo_sa;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Dorée Pourpre";
                    break;
                case ChooseRace.doreeorchidee:
                    parcho = Parchemins.mo_sa;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Dorée Orchidée";
                    break;
                case ChooseRace.indigopourpre:
                    parcho = Parchemins.mo_cha;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Indigo Pourpre";
                    break;
                case ChooseRace.indigoorchidee:
                    parcho = Parchemins.mo_cha;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Indigo Orchidée";
                    break;
                case ChooseRace.ebenepourpre:
                    parcho = Parchemins.mo_agi;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Ebène Pourpre";
                    break;
                case ChooseRace.ebeneorchidee:
                    parcho = Parchemins.mo_agi;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Ebène Orchidée";
                    break;
                case ChooseRace.pourpreorchidee:
                    parcho = Parchemins.mo_int;
                    gen = 6;
                    tempsGestion = 108;
                    name = "Pourpre Orchidée";
                    break;
                case ChooseRace.ivoire:
                    parcho = Parchemins.gr_cha;
                    gen = 7;
                    tempsGestion = 120;
                    name = "Ivoire";
                    break;
                case ChooseRace.turquoise:
                    parcho = Parchemins.gr_agi;
                    gen = 7;
                    tempsGestion = 120;
                    name = "Turquoise";
                    break;
                case ChooseRace.ivoirerousse:
                    parcho = Parchemins.gr_vita;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Ivoire Rousse";
                    break;
                case ChooseRace.turquoiserousse:
                    parcho = Parchemins.gr_vita;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Turquoise Rousse";
                    break;
                case ChooseRace.amandeivoire:
                    parcho = Parchemins.gr_cha;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Amande Ivoire";
                    break;
                case ChooseRace.amandeturquoise:
                    parcho = Parchemins.gr_vita;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Amande Turquoise";
                    break;
                case ChooseRace.doreeivoire:
                    parcho = Parchemins.gr_sa;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Dorée Ivoire";
                    break;
                case ChooseRace.doreeturquoise:
                    parcho = Parchemins.gr_sa;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Dorée Turquoise";
                    break;
                case ChooseRace.indigoivoire:
                    parcho = Parchemins.gr_cha;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Indigo Ivoire";
                    break;
                case ChooseRace.indigoturquoise:
                    parcho = Parchemins.gr_cha;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Indigo Turquoise";
                    break;
                case ChooseRace.ebeneivoire:
                    parcho = Parchemins.gr_agi;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Ebène Ivoire";
                    break;
                case ChooseRace.ebeneturquoise:
                    parcho = Parchemins.gr_agi;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Ebène Turquoise";
                    break;
                case ChooseRace.pourpreivoire:
                    parcho = Parchemins.gr_fo;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Pourpre Ivoire";
                    break;
                case ChooseRace.turquoisepourpre:
                    parcho = Parchemins.gr_fo;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Turquoise Pourpre";
                    break;
                case ChooseRace.ivoireorchidee:
                    parcho = Parchemins.gr_int;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Ivoire Orchidée";
                    break;
                case ChooseRace.turquoiseorchidee:
                    parcho = Parchemins.gr_int;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Turquoise Orchidée";
                    break;
                case ChooseRace.ivoireturquoise:
                    parcho = Parchemins.gr_agi;
                    gen = 8;
                    tempsGestion = 132;
                    name = "Ivoire Turquoise";
                    break;
                case ChooseRace.emeraude:
                    parcho = Parchemins.pui_fo;
                    gen = 9;
                    tempsGestion = 144;
                    name = "Emeraude";
                    break;
                case ChooseRace.prune:
                    parcho = Parchemins.pui_int;
                    gen = 9;
                    tempsGestion = 144;
                    name = "Prune";
                    break;
                case ChooseRace.rousseemeraude:
                    parcho = Parchemins.pui_vita;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Rousse Emeraude";
                    break;
                case ChooseRace.rousseprune:
                    parcho = Parchemins.pui_vita;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Rousse Prune";
                    break;
                case ChooseRace.amandeemeraude:
                    parcho = Parchemins.pui_vita;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Amande Emeraude";
                    break;
                case ChooseRace.amandeprune:
                    parcho = Parchemins.pui_vita;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Amande Prune";
                    break;
                case ChooseRace.doreeemeraude:
                    parcho = Parchemins.pui_sa;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Dorée Emeraude";
                    break;
                case ChooseRace.doreeprune:
                    parcho = Parchemins.pui_sa;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Dorée Prune";
                    break;
                case ChooseRace.indigoemeraude:
                    parcho = Parchemins.pui_cha;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Indigo Emeraude";
                    break;
                case ChooseRace.indigoprune:
                    parcho = Parchemins.pui_cha;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Indigo Prune";
                    break;
                case ChooseRace.ebeneemeraude:
                    parcho = Parchemins.pui_fo;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Ebène Emeraude";
                    break;
                case ChooseRace.ebeneprune:
                    parcho = Parchemins.pui_agi;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Ebène Prune";
                    break;
                case ChooseRace.pourpreemeraude:
                    parcho = Parchemins.pui_fo;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Pourpre Emeraude";
                    break;
                case ChooseRace.pourpreprune:
                    parcho = Parchemins.pui_fo;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Pourpre Prune";
                    break;
                case ChooseRace.orchideeemeraude:
                    parcho = Parchemins.pui_int;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Orchidée Emeraude";
                    break;
                case ChooseRace.orchideeprune:
                    parcho = Parchemins.pui_int;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Orchidée Prune";
                    break;
                case ChooseRace.ivoireemeraude:
                    parcho = Parchemins.pui_cha;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Ivoire Emeraude";
                    break;
                case ChooseRace.ivoireprune:
                    parcho = Parchemins.pui_cha;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Ivoire Prune";
                    break;
                case ChooseRace.turquoiseemeraude:
                    parcho = Parchemins.pui_agi;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Turquoise Emeraude";
                    break;
                case ChooseRace.turquoiseprune:
                    parcho = Parchemins.pui_agi;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Turquoise Prune";
                    break;
                case ChooseRace.emeraudeprune:
                    parcho = Parchemins.pui_int;
                    gen = 10;
                    tempsGestion = 156;
                    name = "Emeraude Prune";
                    break;
                default:
                    parcho = Parchemins.aucun;
                    gen = 0;
                    tempsGestion = -1;
                    name = "erreur";
                    break;
            }
        }
    }
}
