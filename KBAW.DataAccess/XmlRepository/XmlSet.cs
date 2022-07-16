using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace KBAW.DataAccess.XmlRepository;

public class XmlSet<TEntity>
    where TEntity : class
{
    private readonly string _fileName;
    private ICollection<TEntity> _models;

    public XmlSet(string fileName)
    {
        _fileName = fileName;
    }

    public ICollection<TEntity> Data
    {
        get
        {
            try
            {
                if (_models == null)
                {
                    Load();
                }
            }
            catch (Exception)
            {
                _models = new HashSet<TEntity>();
            }

            return _models;
        }

        set
        {
            _models = value;
            Save();
        }
    }

    private void Save()
    {
        var serializer = new XmlSerializer(typeof(HashSet<TEntity>));
        var streamWriter = new StreamWriter(GetXmlStorePath());
        serializer.Serialize(streamWriter, _models);
        streamWriter.Close();
        streamWriter.Dispose();
    }

    private void Load()
    {
        var serializer = new XmlSerializer(typeof(HashSet<TEntity>));
        var streamReader = new StreamReader(GetXmlStorePath());
        _models = serializer.Deserialize(streamReader) as HashSet<TEntity>;
        streamReader.Close();
        streamReader.Dispose();
    }

    private string GetXmlStorePath()
    {
        string path = @$"KBAW.DataAccess\XmlStore\{_fileName}";
        return Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\", path));
    }
}