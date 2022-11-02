using System;
using CryptoWatcherLib.Models;
using MySqlConnector;

namespace Crypto_Watcher_1._0.Repositories;

public class RecordRepository : RepositoryBase, IRecord
{
    public void Add(RecordModel recordModel)
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        conn = GetDbConnectionString();
        cmd = new MySqlCommand();

        try
        {
            conn.Open();

        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void Edit(RecordModel recordModel)
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        conn = GetDbConnectionString();
        cmd = new MySqlCommand();

        try
        {
            conn.Open();

        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void Remove(RecordModel recordModel)
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        conn = GetDbConnectionString();
        cmd = new MySqlCommand();

        try
        {
            conn.Open();

        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public RecordModel GetbyID()
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        conn = GetDbConnectionString();
        cmd = new MySqlCommand();

        try
        {
            conn.Open();
            throw new NotImplementedException();
        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}