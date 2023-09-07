using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillProject;
public class VideoGame : IComparable<VideoGame>
{
    public string Name { get; set; }
    public string Platform { get; set; }
    public string Year { get; set; }
    public string Genre { get; set; }
    public string Publisher { get; set; }
    public string NASales { get; set; }
    public string EUSales { get; set; }
    public string JPSales { get; set; }
    public string OtherSales { get; set; }
    public string GlobalSales { get; set; }

    public VideoGame()
    {

    }

    public VideoGame(string name, string platform, string year, string genre, string publisher, string naSales, string euSales, string jpSales, string otherSales, string globalSales)
    {
        Name = name;
        Platform = platform;
        Year = year;
        Genre = genre;
        Publisher = publisher;
        NASales = naSales;
        EUSales = euSales;
        JPSales = jpSales;
        OtherSales = otherSales;
        GlobalSales = globalSales;
    }

    public int CompareTo(VideoGame other)
    {
        return Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        string videoGameString = "";
        videoGameString += $"Name: {Name}\n";
        videoGameString += $"Platform: {Platform}\n";
        videoGameString += $"Year: {Year}\n";
        videoGameString += $"Genre: {Genre}\n";
        videoGameString += $"Publisher: {Publisher}\n";
        videoGameString += $"NASales: {NASales}\n";
        videoGameString += $"EUSales: {EUSales}\n";
        videoGameString += $"JPSales: {JPSales}\n";
        videoGameString += $"OtherSales: {OtherSales}\n";
        videoGameString += $"GlobalSales: {GlobalSales}\n";
        return videoGameString;
    }
}






