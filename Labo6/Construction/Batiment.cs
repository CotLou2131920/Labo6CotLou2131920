using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Construction
{
    enum Statut
    {
        parfait,
        reparation,
        demoli
    }


    class Batiment
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Statut etatBatiment { get; set; }
        public int resource { get; set; }
        public int priorite { get; set; }
        static int countBati;
        int id;

        public Batiment(int x, int y, Statut etatBatiment, int resource, int priorite)
        {
            id = ++countBati;
            this.PositionX = x;
            this.PositionY = y;
            this.etatBatiment = etatBatiment;
            this.resource = resource;
            this.priorite = priorite;
        }

        public override string ToString()
        {
            string info = $"Le Batiment {id} \n" +
                $"Position X : {PositionX} \n" +
                $"Position Y : {PositionY} \n" +
                $"Etat du batiment {etatBatiment.Humanize()} \n" +
                $"Resource necessaire : {resource} \n" +
                $"Priorité : {priorite}  \n";
            return info;
        }
    }
}
