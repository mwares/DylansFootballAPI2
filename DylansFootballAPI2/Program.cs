﻿using RestSharp;
using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace DylansFootballAPI2
{
    public class Teams
    {
        public int team_id { get; set; }
        public string name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://api-football-v1.p.rapidapi.com/v2/teams/league/2790/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "api-football-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "ENTER_YOUR_API_KEY_HERE");
            IRestResponse response = client.Execute(request);
            string json = response.Content.ToString();

            //Use this string so you don't need to keep calling the api
            //string json = @"{'api':{'results':20,'teams':[{'team_id':44,'name':'Burnley','code':null,'logo':'https://media.api-sports.io/football/teams/44.png','country':'England','is_national':false,'founded':1882,'venue_name':'Turf Moor','venue_surface':'grass','venue_address':'Harry Potts Way','venue_city':'Burnley','venue_capacity':22546},{'team_id':33,'name':'Manchester United','code':'MUN','logo':'https://media.api-sports.io/football/teams/33.png','country':'England','is_national':false,'founded':1878,'venue_name':'Old Trafford','venue_surface':'grass','venue_address':'Sir Matt Busby Way','venue_city':'Manchester','venue_capacity':76212},{'team_id':52,'name':'Crystal Palace','code':null,'logo':'https://media.api-sports.io/football/teams/52.png','country':'England','is_national':false,'founded':1905,'venue_name':'Selhurst Park','venue_surface':'grass','venue_address':'Holmesdale Road','venue_city':'London','venue_capacity':26309},{'team_id':41,'name':'Southampton','code':null,'logo':'https://media.api-sports.io/football/teams/41.png','country':'England','is_national':false,'founded':1885,'venue_name':'St. Mary&apos;s Stadium','venue_surface':'grass','venue_address':'Britannia Road','venue_city':'Southampton, Hampshire','venue_capacity':32689},{'team_id':36,'name':'Fulham','code':null,'logo':'https://media.api-sports.io/football/teams/36.png','country':'England','is_national':false,'founded':1879,'venue_name':'Craven Cottage','venue_surface':'grass','venue_address':'Stevenage Road','venue_city':'London','venue_capacity':25700},{'team_id':42,'name':'Arsenal','code':null,'logo':'https://media.api-sports.io/football/teams/42.png','country':'England','is_national':false,'founded':1886,'venue_name':'Emirates Stadium','venue_surface':'grass','venue_address':'Queensland Road','venue_city':'London','venue_capacity':60383},{'team_id':40,'name':'Liverpool','code':null,'logo':'https://media.api-sports.io/football/teams/40.png','country':'England','is_national':false,'founded':1892,'venue_name':'Anfield','venue_surface':'grass','venue_address':'Anfield Road','venue_city':'Liverpool','venue_capacity':55212},{'team_id':63,'name':'Leeds','code':null,'logo':'https://media.api-sports.io/football/teams/63.png','country':'England','is_national':false,'founded':1919,'venue_name':'Elland Road','venue_surface':'grass','venue_address':'Elland Road','venue_city':'Leeds, West Yorkshire','venue_capacity':40204},{'team_id':50,'name':'Manchester City','code':null,'logo':'https://media.api-sports.io/football/teams/50.png','country':'England','is_national':false,'founded':1880,'venue_name':'Etihad Stadium','venue_surface':'grass','venue_address':'Rowsley Street','venue_city':'Manchester','venue_capacity':55097},{'team_id':66,'name':'Aston Villa','code':null,'logo':'https://media.api-sports.io/football/teams/66.png','country':'England','is_national':false,'founded':1874,'venue_name':'Villa Park','venue_surface':'grass','venue_address':'Trinity Road','venue_city':'Birmingham','venue_capacity':42788},{'team_id':47,'name':'Tottenham','code':null,'logo':'https://media.api-sports.io/football/teams/47.png','country':'England','is_national':false,'founded':1882,'venue_name':'Tottenham Hotspur Stadium','venue_surface':'grass','venue_address':'Bill Nicholson Way, 748 High Road','venue_city':'London','venue_capacity':62062},{'team_id':45,'name':'Everton','code':null,'logo':'https://media.api-sports.io/football/teams/45.png','country':'England','is_national':false,'founded':1878,'venue_name':'Goodison Park','venue_surface':'grass','venue_address':'Goodison Road','venue_city':'Liverpool','venue_capacity':40569},{'team_id':60,'name':'West Brom','code':null,'logo':'https://media.api-sports.io/football/teams/60.png','country':'England','is_national':false,'founded':1878,'venue_name':'The Hawthorns','venue_surface':'grass','venue_address':'Halfords Lane','venue_city':'West Bromwich','venue_capacity':28003},{'team_id':46,'name':'Leicester','code':null,'logo':'https://media.api-sports.io/football/teams/46.png','country':'England','is_national':false,'founded':1884,'venue_name':'King Power Stadium','venue_surface':'grass','venue_address':'Filbert Way','venue_city':'Leicester, Leicestershire','venue_capacity':32262},{'team_id':48,'name':'West Ham','code':null,'logo':'https://media.api-sports.io/football/teams/48.png','country':'England','is_national':false,'founded':1895,'venue_name':'London Stadium','venue_surface':'grass','venue_address':'Marshgate Lane, Stratford','venue_city':'London','venue_capacity':60000},{'team_id':34,'name':'Newcastle','code':null,'logo':'https://media.api-sports.io/football/teams/34.png','country':'England','is_national':false,'founded':1892,'venue_name':'St. James&apos; Park','venue_surface':'grass','venue_address':'St. James&apos; Street','venue_city':'Newcastle upon Tyne','venue_capacity':52389},{'team_id':51,'name':'Brighton','code':null,'logo':'https://media.api-sports.io/football/teams/51.png','country':'England','is_national':false,'founded':1901,'venue_name':'The American Express Community Stadium','venue_surface':'grass','venue_address':'Village Way','venue_city':'Falmer, East Sussex','venue_capacity':30750},{'team_id':49,'name':'Chelsea','code':null,'logo':'https://media.api-sports.io/football/teams/49.png','country':'England','is_national':false,'founded':1905,'venue_name':'Stamford Bridge','venue_surface':'grass','venue_address':'Fulham Road','venue_city':'London','venue_capacity':41841},{'team_id':62,'name':'Sheffield Utd','code':null,'logo':'https://media.api-sports.io/football/teams/62.png','country':'England','is_national':false,'founded':1889,'venue_name':'Bramall Lane','venue_surface':'grass','venue_address':'Bramall Lane','venue_city':'Sheffield','venue_capacity':32702},{'team_id':39,'name':'Wolves','code':null,'logo':'https://media.api-sports.io/football/teams/39.png','country':'England','is_national':false,'founded':1877,'venue_name':'Molineux Stadium','venue_surface':'grass','venue_address':'Waterloo Road','venue_city':'Wolverhampton, West Midlands','venue_capacity':32050}]}}";

            JObject teamsJSON = JObject.Parse(json);

            IList<JToken> listOfTeams = teamsJSON["api"]["teams"].Children().ToList();

            IList<Teams> teams = new List<Teams>();
            foreach (JToken result in listOfTeams)
            {
                Teams team = result.ToObject<Teams>();
                teams.Add(team);
            }

        }
    }
}
