using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components;

namespace CadeauRies2024.models;

public class Loginries
{
    
    public string Email { get; set; }
    public string Wachtwoord { get; set; }
    public string Feedback { get; set; }
    private NavigationManager _NavigationManager;

    public Loginries(string email, string wachtwoord, string feedback, NavigationManager navigationManager)
    {
        this.Email = email;
        this.Wachtwoord = wachtwoord;
        this.Feedback = feedback;
        _NavigationManager = navigationManager;

    }

    public string CheckLogin(string wachtwoord)
    {

        if (wachtwoord.ToLower() == "avontuur")
        {
            _NavigationManager.NavigateTo("/Home");
            return "";
        }else
        {
            return "Foutief probeer het nog eens!";
        }


    }



}
