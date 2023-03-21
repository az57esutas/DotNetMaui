﻿using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    HttpClient httpClient;
    public MonkeyService()
    {
        httpClient = new HttpClient();
    }

    List<Monkey> monkeyList = new ();
    public async Task<List<Monkey>> GetMonkeys()
    {
        if(monkeyList?.Count > 0)
            return monkeyList;
        
        var url = "https://montemagno.com/monkeys.json";
        
        var response = await httpClient.GetAsync(url);

        if(response.IsSuccessStatusCode) 
        {   
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        //Lokál megnyitás verzió
        // ez akkor kell, ha lokálban van a JSON file, pl nem lehet kitenni a netre stb....

        /*
        string file = "monkeydata.json";
        using var stream = await FileSystem.OpenAppPackageFileAsync(file);
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        monkeyList = JsonSerializer.Deserialize<List<Monkey>>(contents);
        */

        return monkeyList;
    }
}
