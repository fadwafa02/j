﻿using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> 61ed9b479b64c8265dc881c79083c29c1e595b83
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        /// getter sur les suivis
        /// </summary>
        /// <returns>Liste d'objets Suivi</returns>
        public List<Suivi> GetAllSuivis()
        {
            return access.GetAllSuivis();
        }

        /// <summary>
        /// récupère les commandes d'un document
        /// </summary>
        /// <param name="idDocument"></param>
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public List<CommandeDocument> GetCommandesDocument(string idDocument)
        {
            return access.GetCommandesDocument(idDocument);
        }

        /// <summary>
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> 61ed9b479b64c8265dc881c79083c29c1e595b83
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// Crée un document dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Titre"></param>
        /// <param name="Image"></param>
        /// <param name="IdGenre"></param>
        /// <param name="IdPublic"></param>
        /// <param name="IdRayon"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool CreerDocument(string Id, string Titre, string Image, string IdRayon, string IdPublic, string IdGenre)
        {
            return access.CreerDocument(Id, Titre, Image, IdRayon, IdPublic, IdGenre);
        }

        /// <summary>
        /// Modifie un document dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Titre"></param>
        /// <param name="Image"></param>
        /// <param name="IdGenre"></param>
        /// <param name="IdPublic"></param>
        /// <param name="IdRayon"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool ModifierDocument(string Id, string Titre, string Image, string IdGenre, string IdPublic, string IdRayon)
        {
            return access.ModifierDocument(Id, Titre, Image, IdGenre, IdPublic, IdRayon);
        }

        /// <summary>
        /// Supprime un document dans la bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool SupprimerDocument(string Id)
        {
            return access.SupprimerDocument(Id);
        }

        /// <summary>
        /// Crée un livre dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Isbn"></param>
        /// <param name="Auteur"></param>
        /// <param name="Collection"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool CreerLivre(string Id, string Isbn, string Auteur, string Collection)
        {
            return access.CreerLivre(Id, Isbn, Auteur, Collection);
        }

        /// <summary>
        /// Modifie un livre dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Isbn"></param>
        /// <param name="Auteur"></param>
        /// <param name="Collection"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool ModifierLivre(string Id, string Isbn, string Auteur, string Collection)
        {
            return access.ModifierLivre(Id, Isbn, Auteur, Collection);
        }

        /// <summary>
        /// Suppression d'un livre en bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool SupprimerLivre(string Id)
        {
            return access.SupprimerLivre(Id);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6c593cf004906a71bd47ceaf25665b7e3a14dc1d
>>>>>>> 61ed9b479b64c8265dc881c79083c29c1e595b83
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        /// <summary>
        /// Créé un Dvd dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Synopsis"></param>
        /// <param name="Realisateur"></param>
        /// <param name="Duree"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool CreerDvd(string Id, string Synopsis, string Realisateur, int Duree)
        {
            return access.CreerDvd(Id, Synopsis, Realisateur, Duree);
        }

        /// <summary>
        /// Modifie un dvd dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Synopsis"></param>
        /// <param name="Realisateur"></param>
        /// <param name="Duree"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool ModifierDvd(string Id, string Synopsis, string Realisateur, int Duree)
        {
            return access.ModifierDvd(Id, Synopsis, Realisateur, Duree);
        }

        /// <summary>
        /// Supprimme un dvd dans la bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool SupprimerDvd(string Id)
        {
            return access.SupprimerDvd(Id);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 61ed9b479b64c8265dc881c79083c29c1e595b83
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        /// <summary>
        /// Crée une revue dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Periodicite"></param>
        /// <param name="DelaiMiseADispo"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool CreerRevue(string Id, string Periodicite, int DelaiMiseADispo)
        {
            return access.CreerRevue(Id, Periodicite, DelaiMiseADispo);
        }

        /// <summary>
        /// Modifie une revue dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Periodicite"></param>
        /// <param name="DelaiMiseADispo"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool ModifierRevue(string Id, string Periodicite, int DelaiMiseADispo)
        {
            return access.ModifierRevue(Id, Periodicite, DelaiMiseADispo);
        }

        /// <summary>
        /// Supprime une revue dans la bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        public bool SupprimerRevue(string Id)
        {
            return access.SupprimerRevue(Id);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
        /// <summary>
        /// Créé une commande dans la bdd
        /// </summary>
        /// <param name="commande"></param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommande(Commande commande)
        {
            return access.CreerCommande(commande);
        }

        /// <summary>
        /// Créé une commande de document dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nbExemplaire"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="idSuivi"></param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommandeDocument(string id, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            return access.CreerCommandeDocument(id, nbExemplaire, idLivreDvd, idSuivi);
        }

        /// <summary>
        /// Modifie l'étape de suivi d'une commande dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nbExemplaire"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="idSuivi"></param>
        /// <returns>True si la modification a pu se faire</returns>
        internal bool ModifierSuiviCommandeDocument(string id, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            return access.ModifierSuiviCommandeDocument(id, nbExemplaire, idLivreDvd, idSuivi);
        }

        /// <summary>
        /// Supprimme une commande de livre dans la bdd
        /// </summary>
        /// <param name="commandesdocument"></param>
        /// <returns>True si la suppression a pu se faire</returns>
        public bool SupprimerCommandeDocument(CommandeDocument commandesDocument)
        {
            return access.SupprimerCommandeDocument(commandesDocument);
        }


<<<<<<< HEAD
=======
=======

<<<<<<< HEAD
=======
=======


=======
>>>>>>> 2c122a9b48f4f17c6238906aa0fbc9bd4dcd13bc
>>>>>>> 6c593cf004906a71bd47ceaf25665b7e3a14dc1d
>>>>>>> 61ed9b479b64c8265dc881c79083c29c1e595b83
>>>>>>> e78cf01a8defeab371de522e8c98d8d68bda933c
>>>>>>> 1588d5cd69a237fbf9942989284d728a9a5d834b
    }
}
