using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doflevage {

    public class Race {
        public List<ddType> listType = new List<ddType>();

        public Race() {
            listType.Add(new ddType(ChooseRace.inconnu));

            listType.Add(new ddType(ChooseRace.armure));
            listType.Add(new ddType(ChooseRace.plumes));
            listType.Add(new ddType(ChooseRace.squelette));

            listType.Add(new ddType(ChooseRace.rousse));
            listType.Add(new ddType(ChooseRace.amande));
            listType.Add(new ddType(ChooseRace.doree));

            listType.Add(new ddType(ChooseRace.rousseamande));
            listType.Add(new ddType(ChooseRace.roussedoree));
            listType.Add(new ddType(ChooseRace.amandedoree));


            listType.Add(new ddType(ChooseRace.indigo));
            listType.Add(new ddType(ChooseRace.ebene));

            listType.Add(new ddType(ChooseRace.rousseindigo));
            listType.Add(new ddType(ChooseRace.rousseebene));
            listType.Add(new ddType(ChooseRace.amandeindigo));
            listType.Add(new ddType(ChooseRace.amandeebene));
            listType.Add(new ddType(ChooseRace.doreeindigo));
            listType.Add(new ddType(ChooseRace.doreeebene));
            listType.Add(new ddType(ChooseRace.indigoebene));

            listType.Add(new ddType(ChooseRace.pourpre));
            listType.Add(new ddType(ChooseRace.orchidee));

            listType.Add(new ddType(ChooseRace.pourprerousse));
            listType.Add(new ddType(ChooseRace.orchideerousse));
            listType.Add(new ddType(ChooseRace.amandepourpre));
            listType.Add(new ddType(ChooseRace.amandeorchidee));
            listType.Add(new ddType(ChooseRace.doreepourpre));
            listType.Add(new ddType(ChooseRace.doreeorchidee));
            listType.Add(new ddType(ChooseRace.indigopourpre));
            listType.Add(new ddType(ChooseRace.indigoorchidee));
            listType.Add(new ddType(ChooseRace.ebenepourpre));
            listType.Add(new ddType(ChooseRace.ebeneorchidee));
            listType.Add(new ddType(ChooseRace.pourpreorchidee));

            listType.Add(new ddType(ChooseRace.ivoire));
            listType.Add(new ddType(ChooseRace.turquoise));

            listType.Add(new ddType(ChooseRace.ivoirerousse));
            listType.Add(new ddType(ChooseRace.turquoiserousse));
            listType.Add(new ddType(ChooseRace.amandeivoire));
            listType.Add(new ddType(ChooseRace.amandeturquoise));
            listType.Add(new ddType(ChooseRace.doreeivoire));
            listType.Add(new ddType(ChooseRace.doreeturquoise));
            listType.Add(new ddType(ChooseRace.indigoivoire));
            listType.Add(new ddType(ChooseRace.indigoturquoise));
            listType.Add(new ddType(ChooseRace.ebeneivoire));
            listType.Add(new ddType(ChooseRace.ebeneturquoise));
            listType.Add(new ddType(ChooseRace.pourpreivoire));
            listType.Add(new ddType(ChooseRace.turquoisepourpre));
            listType.Add(new ddType(ChooseRace.ivoireorchidee));
            listType.Add(new ddType(ChooseRace.turquoiseorchidee));
            listType.Add(new ddType(ChooseRace.ivoireturquoise));

            listType.Add(new ddType(ChooseRace.emeraude));
            listType.Add(new ddType(ChooseRace.prune));

            listType.Add(new ddType(ChooseRace.rousseemeraude));
            listType.Add(new ddType(ChooseRace.rousseprune));
            listType.Add(new ddType(ChooseRace.amandeemeraude));
            listType.Add(new ddType(ChooseRace.amandeprune));
            listType.Add(new ddType(ChooseRace.doreeemeraude));
            listType.Add(new ddType(ChooseRace.doreeprune));
            listType.Add(new ddType(ChooseRace.indigoemeraude));
            listType.Add(new ddType(ChooseRace.indigoprune));
            listType.Add(new ddType(ChooseRace.ebeneemeraude));
            listType.Add(new ddType(ChooseRace.ebeneprune));
            listType.Add(new ddType(ChooseRace.pourpreemeraude));
            listType.Add(new ddType(ChooseRace.pourpreprune));
            listType.Add(new ddType(ChooseRace.orchideeemeraude));
            listType.Add(new ddType(ChooseRace.orchideeprune));
            listType.Add(new ddType(ChooseRace.ivoireemeraude));
            listType.Add(new ddType(ChooseRace.ivoireprune));
            listType.Add(new ddType(ChooseRace.turquoiseemeraude));
            listType.Add(new ddType(ChooseRace.turquoiseprune));
            listType.Add(new ddType(ChooseRace.emeraudeprune));
        }



    }
}
