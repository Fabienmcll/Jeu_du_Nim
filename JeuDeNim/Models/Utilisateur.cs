using System;
using System.Collections.Generic;

namespace JeuDeNim.Models;

public partial class Utilisateur
{
    public int IdJoueur { get; set; }

    public string Pseudo { get; set; } = null!;

    public string Mdp { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public int? NbVictoire { get; set; }

    public virtual ICollection<Partie> PartieIdJoueur1Navigations { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieIdJoueur2Navigations { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieIdVainqueurNavigations { get; set; } = new List<Partie>();

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
