using System;
using System.Collections.Generic;

namespace JeuDeNim.Models;

public partial class Tour
{
    public int IdTour { get; set; }

    public int? NbBatonnetsRetires { get; set; }

    public int IdJoueur { get; set; }

    public int IdPartie { get; set; }

    public virtual Utilisateur IdJoueurNavigation { get; set; } = null!;

    public virtual Partie IdPartieNavigation { get; set; } = null!;
}
