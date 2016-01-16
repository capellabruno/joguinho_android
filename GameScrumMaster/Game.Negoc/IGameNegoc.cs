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


    }
}