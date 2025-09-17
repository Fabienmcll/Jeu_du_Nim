using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeuDeNim.Models;

public partial class Partie
{
    public int IdPartie { get; set; }

    public int NbJoueur { get; set; }

    public bool EstJoueur1 { get; set; }

    public DateTime DateCreation { get; set; }

    public string CodePartie { get; set; } = null!;

    public int NbBatonnetsTotal { get; set; }

    public int NbBatonnetsEnCours { get; set; }

    public bool EstTerminee { get; set; }

    public int? IdVainqueur { get; set; }

    public int IdJoueur1 { get; set; }

    public int? IdJoueur2 { get; set; }

    public virtual Utilisateur IdJoueur1Navigation { get; set; } = null!;

    public virtual Utilisateur IdJoueur2Navigation { get; set; } = null!;

    public virtual Utilisateur? IdVainqueurNavigation { get; set; }

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
