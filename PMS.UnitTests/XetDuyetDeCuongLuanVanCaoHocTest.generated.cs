﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file XetDuyetDeCuongLuanVanCaoHocTest.cs instead.
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
    /// Provides tests for the and <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class XetDuyetDeCuongLuanVanCaoHocTest
    {
    	// the XetDuyetDeCuongLuanVanCaoHoc instance used to test the repository.
		protected XetDuyetDeCuongLuanVanCaoHoc mock;
		
		// the TList<XetDuyetDeCuongLuanVanCaoHoc> instance used to test the repository.
		protected TList<XetDuyetDeCuongLuanVanCaoHoc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the XetDuyetDeCuongLuanVanCaoHoc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock XetDuyetDeCuongLuanVanCaoHoc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all XetDuyetDeCuongLuanVanCaoHoc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all XetDuyetDeCuongLuanVanCaoHoc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.DeepLoading += new EntityProviderBaseCore<XetDuyetDeCuongLuanVanCaoHoc, XetDuyetDeCuongLuanVanCaoHocKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("XetDuyetDeCuongLuanVanCaoHoc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock XetDuyetDeCuongLuanVanCaoHoc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				XetDuyetDeCuongLuanVanCaoHoc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock XetDuyetDeCuongLuanVanCaoHoc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (XetDuyetDeCuongLuanVanCaoHoc)CreateMockInstance(tm);
				DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock XetDuyetDeCuongLuanVanCaoHoc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_XetDuyetDeCuongLuanVanCaoHoc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock XetDuyetDeCuongLuanVanCaoHoc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_XetDuyetDeCuongLuanVanCaoHoc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<XetDuyetDeCuongLuanVanCaoHoc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a XetDuyetDeCuongLuanVanCaoHoc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_XetDuyetDeCuongLuanVanCaoHocCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<XetDuyetDeCuongLuanVanCaoHoc> mockCollection = new TList<XetDuyetDeCuongLuanVanCaoHoc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<XetDuyetDeCuongLuanVanCaoHoc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a XetDuyetDeCuongLuanVanCaoHoc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_XetDuyetDeCuongLuanVanCaoHocCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<XetDuyetDeCuongLuanVanCaoHoc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<XetDuyetDeCuongLuanVanCaoHoc> mockCollection = (TList<XetDuyetDeCuongLuanVanCaoHoc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<XetDuyetDeCuongLuanVanCaoHoc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				XetDuyetDeCuongLuanVanCaoHoc entity = CreateMockInstance(tm);
				bool result = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<XetDuyetDeCuongLuanVanCaoHoc> t0 = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.GetByMaGiangVien(tm, entity.MaGiangVien, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				XetDuyetDeCuongLuanVanCaoHoc entity = CreateMockInstance(tm);
				bool result = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				XetDuyetDeCuongLuanVanCaoHoc t0 = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.GetById(tm, entity.Id);
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
				
				XetDuyetDeCuongLuanVanCaoHoc entity = mock.Copy() as XetDuyetDeCuongLuanVanCaoHoc;
				entity = (XetDuyetDeCuongLuanVanCaoHoc)mock.Clone();
				Assert.IsTrue(XetDuyetDeCuongLuanVanCaoHoc.ValueEquals(entity, mock), "Clone is not working");
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
				XetDuyetDeCuongLuanVanCaoHoc mock = CreateMockInstance(tm);
				bool result = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				XetDuyetDeCuongLuanVanCaoHocQuery query = new XetDuyetDeCuongLuanVanCaoHocQuery();
			
				query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.MaKhoaHoc != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.MaKhoaHoc, mock.MaKhoaHoc.ToString());
				if(mock.SoLuong != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.SoLuong, mock.SoLuong.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.DonGia, mock.DonGia.ToString());
				if(mock.ThanhTien != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.ThanhTien, mock.ThanhTien.ToString());
				if(mock.Thue != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.Thue, mock.Thue.ToString());
				if(mock.ThucLinh != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.ThucLinh, mock.ThucLinh.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.Chot != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.Chot, mock.Chot.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(XetDuyetDeCuongLuanVanCaoHocColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				
				TList<XetDuyetDeCuongLuanVanCaoHoc> results = DataRepository.XetDuyetDeCuongLuanVanCaoHocProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed XetDuyetDeCuongLuanVanCaoHoc Entity with mock values.
		///</summary>
		static public XetDuyetDeCuongLuanVanCaoHoc CreateMockInstance_Generated(TransactionManager tm)
		{		
			XetDuyetDeCuongLuanVanCaoHoc mock = new XetDuyetDeCuongLuanVanCaoHoc();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.Thue = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucLinh = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.Chot = TestUtility.Instance.RandomBoolean();
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
			//OneToOneRelationship
			GiangVien mockGiangVienByMaGiangVien = GiangVienTest.CreateMockInstance(tm);
			DataRepository.GiangVienProvider.Insert(tm, mockGiangVienByMaGiangVien);
			mock.MaGiangVien = mockGiangVienByMaGiangVien.MaGiangVien;
		
			// create a temporary collection and add the item to it
			TList<XetDuyetDeCuongLuanVanCaoHoc> tempMockCollection = new TList<XetDuyetDeCuongLuanVanCaoHoc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (XetDuyetDeCuongLuanVanCaoHoc)mock;
		}
		
		
		///<summary>
		///  Update the Typed XetDuyetDeCuongLuanVanCaoHoc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, XetDuyetDeCuongLuanVanCaoHoc mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.Thue = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucLinh = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.Chot = TestUtility.Instance.RandomBoolean();
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
			//OneToOneRelationship
			GiangVien mockGiangVienByMaGiangVien = GiangVienTest.CreateMockInstance(tm);
			DataRepository.GiangVienProvider.Insert(tm, mockGiangVienByMaGiangVien);
			mock.MaGiangVien = mockGiangVienByMaGiangVien.MaGiangVien;
					
		}
		#endregion
    }
}
