namespace MinVer.Lib;

public enum VersionPart
{
    None = -1,
    Patch = 0,
    Minor = 1,
    Major = 2,
}

public static class VersionPartExtensions
{
    public static string ValidValues => "major, minor, or patch (default)";
}
