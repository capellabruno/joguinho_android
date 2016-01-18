using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Game.Domain;

namespace Game.Negoc
{
    public interface IGameNegoc
    {
        void JoinRoom();

        void AddPeople(Pessoa people);

        void CreateTable(RoomGame Game);
        
        /////////////////Scrum Master/////////////////////////////
        /*
            Funções do ScrumMaster
    
            Montar Equipe (selecionar um lider de equipe)
            Administrar Reunião
            Verificar Entrega e Impedimento
            Indicar Advertencia ao Programador
        
        */
        void MontarEquipe(bool EhLiderEquipe);
        
        void AdministrarReuniao();
        
        void TeveEntrega();
        
        void TeveImpedimento();
        
        void DarAdvertencia();

    }
}
