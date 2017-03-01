﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file PscExBarCodesTest.cs instead.
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
    /// Provides tests for the and <see cref="PscExBarCodes"/> objects (entity, collection and repository).
    /// </summary>
   public partial class PscExBarCodesTest
    {
    	// the PscExBarCodes instance used to test the repository.
		protected PscExBarCodes mock;
		
		// the TList<PscExBarCodes> instance used to test the repository.
		protected TList<PscExBarCodes> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the PscExBarCodes Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock PscExBarCodes entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PscExBarCodesProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.PscExBarCodesProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all PscExBarCodes objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.PscExBarCodesProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.PscExBarCodesProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.PscExBarCodesProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all PscExBarCodes children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.PscExBarCodesProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.PscExBarCodesProvider.DeepLoading += new EntityProviderBaseCore<PscExBarCodes, PscExBarCodesKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.PscExBarCodesProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("PscExBarCodes instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.PscExBarCodesProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock PscExBarCodes entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PscExBarCodes mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PscExBarCodesProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.PscExBarCodesProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.PscExBarCodesProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock PscExBarCodes entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (PscExBarCodes)CreateMockInstance(tm);
				DataRepository.PscExBarCodesProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.PscExBarCodesProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.PscExBarCodesProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock PscExBarCodes entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscExBarCodes.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock PscExBarCodes entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscExBarCodes.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<PscExBarCodes>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a PscExBarCodes collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscExBarCodesCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<PscExBarCodes> mockCollection = new TList<PscExBarCodes>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<PscExBarCodes> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a PscExBarCodes collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscExBarCodesCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<PscExBarCodes>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<PscExBarCodes> mockCollection = (TList<PscExBarCodes>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<PscExBarCodes> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PscExBarCodes entity = CreateMockInstance(tm);
				bool result = DataRepository.PscExBarCodesProvider.Insert(tm, entity);
				
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
				PscExBarCodes entity = CreateMockInstance(tm);
				bool result = DataRepository.PscExBarCodesProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				PscExBarCodes t0 = DataRepository.PscExBarCodesProvider.GetByMaLopHocPhanKyThiLanThiBarCode(tm, entity.MaLopHocPhan, entity.KyThi, entity.LanThi, entity.BarCode);
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
				
				PscExBarCodes entity = mock.Copy() as PscExBarCodes;
				entity = (PscExBarCodes)mock.Clone();
				Assert.IsTrue(PscExBarCodes.ValueEquals(entity, mock), "Clone is not working");
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
				PscExBarCodes mock = CreateMockInstance(tm);
				bool result = DataRepository.PscExBarCodesProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				PscExBarCodesQuery query = new PscExBarCodesQuery();
			
				query.AppendEquals(PscExBarCodesColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				query.AppendEquals(PscExBarCodesColumn.KyThi, mock.KyThi.ToString());
				query.AppendEquals(PscExBarCodesColumn.LanThi, mock.LanThi.ToString());
				query.AppendEquals(PscExBarCodesColumn.BarCode, mock.BarCode.ToString());
				if(mock.MaNhanDang != null)
					query.AppendEquals(PscExBarCodesColumn.MaNhanDang, mock.MaNhanDang.ToString());
				if(mock.GiaoBai != null)
					query.AppendEquals(PscExBarCodesColumn.GiaoBai, mock.GiaoBai.ToString());
				if(mock.NhanBai != null)
					query.AppendEquals(PscExBarCodesColumn.NhanBai, mock.NhanBai.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(PscExBarCodesColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.UpdateDate != null)
					query.AppendEquals(PscExBarCodesColumn.UpdateDate, mock.UpdateDate.ToString());
				if(mock.UpdateStaff != null)
					query.AppendEquals(PscExBarCodesColumn.UpdateStaff, mock.UpdateStaff.ToString());
				if(mock.NgayNhan != null)
					query.AppendEquals(PscExBarCodesColumn.NgayNhan, mock.NgayNhan.ToString());
				if(mock.NguoiNhan != null)
					query.AppendEquals(PscExBarCodesColumn.NguoiNhan, mock.NguoiNhan.ToString());
				if(mock.NgayGiao != null)
					query.AppendEquals(PscExBarCodesColumn.NgayGiao, mock.NgayGiao.ToString());
				if(mock.NguoiGiao != null)
					query.AppendEquals(PscExBarCodesColumn.NguoiGiao, mock.NguoiGiao.ToString());
				if(mock.DaGuiMailNhacGiaoBai != null)
					query.AppendEquals(PscExBarCodesColumn.DaGuiMailNhacGiaoBai, mock.DaGuiMailNhacGiaoBai.ToString());
				if(mock.DaGuiMailNhacThuHoiBai != null)
					query.AppendEquals(PscExBarCodesColumn.DaGuiMailNhacThuHoiBai, mock.DaGuiMailNhacThuHoiBai.ToString());
				if(mock.DaGuiMailNhacNhanBai != null)
					query.AppendEquals(PscExBarCodesColumn.DaGuiMailNhacNhanBai, mock.DaGuiMailNhacNhanBai.ToString());
				if(mock.SoBai != null)
					query.AppendEquals(PscExBarCodesColumn.SoBai, mock.SoBai.ToString());
				if(mock.SoTo != null)
					query.AppendEquals(PscExBarCodesColumn.SoTo, mock.SoTo.ToString());
				
				TList<PscExBarCodes> results = DataRepository.PscExBarCodesProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed PscExBarCodes Entity with mock values.
		///</summary>
		static public PscExBarCodes CreateMockInstance_Generated(TransactionManager tm)
		{		
			PscExBarCodes mock = new PscExBarCodes();
						
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(14, false);;
			mock.KyThi = TestUtility.Instance.RandomString(14, false);;
			mock.LanThi = TestUtility.Instance.RandomNumber();
			mock.BarCode = TestUtility.Instance.RandomString(14, false);;
			mock.MaNhanDang = TestUtility.Instance.RandomString(14, false);;
			mock.GiaoBai = TestUtility.Instance.RandomBoolean();
			mock.NhanBai = TestUtility.Instance.RandomBoolean();
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			mock.UpdateDate = TestUtility.Instance.RandomDateTime();
			mock.UpdateStaff = TestUtility.Instance.RandomString(14, false);;
			mock.NgayNhan = TestUtility.Instance.RandomDateTime();
			mock.NguoiNhan = TestUtility.Instance.RandomString(14, false);;
			mock.NgayGiao = TestUtility.Instance.RandomDateTime();
			mock.NguoiGiao = TestUtility.Instance.RandomString(255, false);;
			mock.DaGuiMailNhacGiaoBai = TestUtility.Instance.RandomBoolean();
			mock.DaGuiMailNhacThuHoiBai = TestUtility.Instance.RandomBoolean();
			mock.DaGuiMailNhacNhanBai = TestUtility.Instance.RandomBoolean();
			mock.SoBai = TestUtility.Instance.RandomNumber();
			mock.SoTo = TestUtility.Instance.RandomNumber();
			
		
			// create a temporary collection and add the item to it
			TList<PscExBarCodes> tempMockCollection = new TList<PscExBarCodes>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (PscExBarCodes)mock;
		}
		
		
		///<summary>
		///  Update the Typed PscExBarCodes Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, PscExBarCodes mock)
		{
			mock.MaNhanDang = TestUtility.Instance.RandomString(14, false);;
			mock.GiaoBai = TestUtility.Instance.RandomBoolean();
			mock.NhanBai = TestUtility.Instance.RandomBoolean();
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			mock.UpdateDate = TestUtility.Instance.RandomDateTime();
			mock.UpdateStaff = TestUtility.Instance.RandomString(14, false);;
			mock.NgayNhan = TestUtility.Instance.RandomDateTime();
			mock.NguoiNhan = TestUtility.Instance.RandomString(14, false);;
			mock.NgayGiao = TestUtility.Instance.RandomDateTime();
			mock.NguoiGiao = TestUtility.Instance.RandomString(255, false);;
			mock.DaGuiMailNhacGiaoBai = TestUtility.Instance.RandomBoolean();
			mock.DaGuiMailNhacThuHoiBai = TestUtility.Instance.RandomBoolean();
			mock.DaGuiMailNhacNhanBai = TestUtility.Instance.RandomBoolean();
			mock.SoBai = TestUtility.Instance.RandomNumber();
			mock.SoTo = TestUtility.Instance.RandomNumber();
			
		}
		#endregion
    }
}