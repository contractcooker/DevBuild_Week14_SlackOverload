using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Models
{
    public class DAL
    {
        private SqlConnection conn;

        public DAL(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public int CreateQuestion(Question q)
        {
            q.Posted = DateTime.Now;
            q.Status = 1; //always create status=1

            string addQuery = "INSERT INTO Questions (Username, Title, Detail, Posted, Category, Tags, Status) ";
            addQuery += "VALUES (@Username, @Title, @Detail, @Posted, @Category, @Tags, @Status)"; 

            return conn.Execute(addQuery, q);
        }

        public IEnumerable<Answer> GetAnswersByQuestionId(int id)
        {
            string queryString = "SELECT * FROM Answers WHERE QuestionId = @id";
            return conn.Query<Answer>(queryString, new { id = id });
        }

        public Question GetQuestionById(int id)
        {
            string queryString = "SELECT * FROM Questions WHERE Id = @id";
            return conn.QueryFirstOrDefault<Question>(queryString, new { id = id });
        }

        public IEnumerable<Question> GetQuestionsMostRecent()
        {
            string queryString = "SELECT TOP 20 * FROM Questions ORDER BY Posted DESC";
            return conn.Query<Question>(queryString);
        }

        public Answer GetAnswerById(int id)
        {
            string queryString = "SELECT * FROM Answers WHERE Id = @id";
            return conn.QueryFirstOrDefault<Answer>(queryString, new { id = id });
        }

        public int UpdateAnswerById(Answer prod)
        {
            string editString = "UPDATE Answers SET Detail = @Detail ";
            editString += "WHERE Id = @Id";
            return conn.Execute(editString, prod);
        }

        public int UpdateQuestionById(Question prod)
        {
            string editString = "UPDATE Questions SET Detail = @Detail ";
            editString += "WHERE Id = @Id";
            return conn.Execute(editString, prod);
        }

        public int CreateAnswer(Answer q)
        {
            q.Posted = DateTime.Now;
             //always create status=1

            string addQuery = "INSERT INTO Answers (Username, Detail, QuestionId, Posted, Upvotes) ";
            addQuery += "VALUES (@Username, @Detail, @QuestionId, @Posted, @Upvotes)";

            return conn.Execute(addQuery, q);
        }

        public IEnumerable<Question> GetSearchResults(string search)
        {
            string queryString = "Select * FROM Questions WHERE Detail LIKE '%' +@search + '%' OR Title LIKE '%' +@search+ '%'";

            return conn.Query<Question>(queryString, new { search = search });
        }

        public void DeleteAnswer(int id)
        {

            string queryString = "DELETE FROM Answers WHERE Id = @id";
            conn.Execute(queryString, new { id = id });
        }
    }
}
