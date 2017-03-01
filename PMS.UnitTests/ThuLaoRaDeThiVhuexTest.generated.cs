﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ThuLaoRaDeThiVhuexTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="ThuLaoRaDeThiVhuex"/> objects (entity, collection and repository).
    /// </summary>
   public partial class ThuLaoRaDeThiVhuexTest
    {
    	// the ThuLaoRaDeThiVhuex instance used to test the repository.
		protected ThuLaoRaDeThiVhuex mock;
		
		// the TList<ThuLaoRaDeThiVhuex> instance used to test the repository.
		protected TList<ThuLaoRaDeThiVhuex> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ThuLaoRaDeThiVhuex Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock ThuLaoRaDeThiVhuex entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThuLaoRaDeThiVhuexProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.ThuLaoRaDeThiVhuexProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all ThuLaoRaDeThiVhuex objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.ThuLaoRaDeThiVhuexProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.ThuLaoRaDeThiVhuexProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.ThuLaoRaDeThiVhuexProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all ThuLaoRaDeThiVhuex children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.ThuLaoRaDeThiVhuexProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.ThuLaoRaDeThiVhuexProvider.DeepLoading += new EntityProviderBaseCore<ThuLaoRaDeThiVhuex, ThuLaoRaDeThiVhuexKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.ThuLaoRaDeThiVhuexProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("ThuLaoRaDeThiVhuex instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.ThuLaoRaDeThiVhuexProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock ThuLaoRaDeThiVhuex entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThuLaoRaDeThiVhuex mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThuLaoRaDeThiVhuexProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.ThuLaoRaDeThiVhuexProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.ThuLaoRaDeThiVhuexProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock ThuLaoRaDeThiVhuex entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (ThuLaoRaDeThiVhuex)CreateMockInstance(tm);
				DataRepository.ThuLaoRaDeThiVhuexProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.ThuLaoRaDeThiVhuexProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.ThuLaoRaDeThiVhuexProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ThuLaoRaDeThiVhuex entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuLaoRaDeThiVhuex.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock ThuLaoRaDeThiVhuex entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuLaoRaDeThiVhuex.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<ThuLaoRaDeThiVhuex>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ThuLaoRaDeThiVhuex collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuLaoRaDeThiVhuexCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<ThuLaoRaDeThiVhuex> mockCollection = new TList<ThuLaoRaDeThiVhuex>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<ThuLaoRaDeThiVhuex> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a ThuLaoRaDeThiVhuex collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThuLaoRaDeThiVhuexCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<ThuLaoRaDeThiVhuex>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<ThuLaoRaDeThiVhuex> mockCollection = (TList<ThuLaoRaDeThiVhuex>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<ThuLaoRaDeThiVhuex> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThuLaoRaDeThiVhuex entity = CreateMockInstance(tm);
				bool result = DataRepository.ThuLaoRaDeThiVhuexProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThuLaoRaDeThiVhuex entity = CreateMockInstance(tm);
				bool result = DataRepository.ThuLaoRaDeThiVhuexProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				ThuLaoRaDeThiVhuex t0 = DataRepository.ThuLaoRaDeThiVhuexProvider.GetById(tm, entity.Id);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				ThuLaoRaDeThiVhuex entity = mock.Copy() as ThuLaoRaDeThiVhuex;
				entity = (ThuLaoRaDeThiVhuex)mock.Clone();
				Assert.IsTrue(ThuLaoRaDeThiVhuex.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				ThuLaoRaDeThiVhuex mock = CreateMockInstance(tm);
				bool result = DataRepository.ThuLaoRaDeThiVhuexProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				ThuLaoRaDeThiVhuexQuery query = new ThuLaoRaDeThiVhuexQuery();
			
				query.AppendEquals(ThuLaoRaDeThiVhuexColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.HocKy, mock.HocKy.ToString());
				if(mock.KyThi != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.KyThi, mock.KyThi.ToString());
				if(mock.LanThi != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.LanThi, mock.LanThi.ToString());
				if(mock.DotThanhToan != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.DotThanhToan, mock.DotThanhToan.ToString());
				if(mock.MaGv != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.MaGv, mock.MaGv.ToString());
				if(mock.DotThi != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.DotThi, mock.DotThi.ToString());
				if(mock.TracNghiemDuoi50 != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.TracNghiemDuoi50, mock.TracNghiemDuoi50.ToString());
				if(mock.TracNghiemTren50 != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.TracNghiemTren50, mock.TracNghiemTren50.ToString());
				if(mock.TuLuan != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.TuLuan, mock.TuLuan.ToString());
				if(mock.TongHop != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.TongHop, mock.TongHop.ToString());
				if(mock.VanDap != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.VanDap, mock.VanDap.ToString());
				if(mock.ThucHanh != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.ThucHanh, mock.ThucHanh.ToString());
				if(mock.TieuLuan != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.TieuLuan, mock.TieuLuan.ToString());
				if(mock.GioChuan != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.GioChuan, mock.GioChuan.ToString());
				if(mock.UpdateDate != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.UpdateDate, mock.UpdateDate.ToString());
				if(mock.UpdateStaff != null)
					query.AppendEquals(ThuLaoRaDeThiVhuexColumn.UpdateStaff, mock.UpdateStaff.ToString());
				
				TList<ThuLaoRaDeThiVhuex> results = DataRepository.ThuLaoRaDeThiVhuexProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed ThuLaoRaDeThiVhuex Entity with mock values.
		///</summary>
		static public ThuLaoRaDeThiVhuex CreateMockInstance_Generated(TransactionManager tm)
		{		
			ThuLaoRaDeThiVhuex mock = new ThuLaoRaDeThiVhuex();
						
			mock.NamHoc = TestUtility.Instance.RandomString(10, false);;
			mock.HocKy = TestUtility.Instance.RandomString(10, false);;
			mock.KyThi = TestUtility.Instance.RandomString(14, false);;
			mock.LanThi = TestUtility.Instance.RandomNumber();
			mock.DotThanhToan = TestUtility.Instance.RandomString(14, false);;
			mock.MaGv = TestUtility.Instance.RandomString(9, false);;
			mock.DotThi = TestUtility.Instance.RandomString(499, false);;
			mock.TracNghiemDuoi50 = (decimal)TestUtility.Instance.RandomShort();
			mock.TracNghiemTren50 = (decimal)TestUtility.Instance.RandomShort();
			mock.TuLuan = (decimal)TestUtility.Instance.RandomShort();
			mock.TongHop = (decimal)TestUtility.Instance.RandomShort();
			mock.VanDap = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucHanh = (decimal)TestUtility.Instance.RandomShort();
			mock.TieuLuan = (decimal)TestUtility.Instance.RandomShort();
			mock.GioChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.UpdateDate = TestUtility.Instance.RandomDateTime();
			mock.UpdateStaff = TestUtility.Instance.RandomString(14, false);;
			
		
			// create a temporary collection and add the item to it
			TList<ThuLaoRaDeThiVhuex> tempMockCollection = new TList<ThuLaoRaDeThiVhuex>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (ThuLaoRaDeThiVhuex)mock;
		}
		
		
		///<summary>
		///  Update the Typed ThuLaoRaDeThiVhuex Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, ThuLaoRaDeThiVhuex mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(10, false);;
			mock.HocKy = TestUtility.Instance.RandomString(10, false);;
			mock.KyThi = TestUtility.Instance.RandomString(14, false);;
			mock.LanThi = TestUtility.Instance.RandomNumber();
			mock.DotThanhToan = TestUtility.Instance.RandomString(14, false);;
			mock.MaGv = TestUtility.Instance.RandomString(9, false);;
			mock.DotThi = TestUtility.Instance.RandomString(499, false);;
			mock.TracNghiemDuoi50 = (decimal)TestUtility.Instance.RandomShort();
			mock.TracNghiemTren50 = (decimal)TestUtility.Instance.RandomShort();
			mock.TuLuan = (decimal)TestUtility.Instance.RandomShort();
			mock.TongHop = (decimal)TestUtility.Instance.RandomShort();
			mock.VanDap = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucHanh = (decimal)TestUtility.Instance.RandomShort();
			mock.TieuLuan = (decimal)TestUtility.Instance.RandomShort();
			mock.GioChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.UpdateDate = TestUtility.Instance.RandomDateTime();
			mock.UpdateStaff = TestUtility.Instance.RandomString(14, false);;
			
		}
		#endregion
    }
}
