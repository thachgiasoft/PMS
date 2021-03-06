﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KhoiLuongGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="KhoiLuongGiangDay"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KhoiLuongGiangDayTest
    {
    	// the KhoiLuongGiangDay instance used to test the repository.
		protected KhoiLuongGiangDay mock;
		
		// the TList<KhoiLuongGiangDay> instance used to test the repository.
		protected TList<KhoiLuongGiangDay> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KhoiLuongGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KhoiLuongGiangDay objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KhoiLuongGiangDay children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KhoiLuongGiangDayProvider.DeepLoading += new EntityProviderBaseCore<KhoiLuongGiangDay, KhoiLuongGiangDayKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KhoiLuongGiangDayProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KhoiLuongGiangDay instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KhoiLuongGiangDayProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDay mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KhoiLuongGiangDay entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KhoiLuongGiangDay)CreateMockInstance(tm);
				DataRepository.KhoiLuongGiangDayProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KhoiLuongGiangDay entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDay.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KhoiLuongGiangDay entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDay.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KhoiLuongGiangDay>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KhoiLuongGiangDay collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KhoiLuongGiangDay> mockCollection = new TList<KhoiLuongGiangDay>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KhoiLuongGiangDay> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KhoiLuongGiangDay collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KhoiLuongGiangDay>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KhoiLuongGiangDay> mockCollection = (TList<KhoiLuongGiangDay>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KhoiLuongGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<KhoiLuongGiangDay> t0 = DataRepository.KhoiLuongGiangDayProvider.GetByMaKetQua(tm, entity.MaKetQua, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDay entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KhoiLuongGiangDay t0 = DataRepository.KhoiLuongGiangDayProvider.GetByMaKhoiLuong(tm, entity.MaKhoiLuong);
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
				
				KhoiLuongGiangDay entity = mock.Copy() as KhoiLuongGiangDay;
				entity = (KhoiLuongGiangDay)mock.Clone();
				Assert.IsTrue(KhoiLuongGiangDay.ValueEquals(entity, mock), "Clone is not working");
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
				KhoiLuongGiangDay mock = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KhoiLuongGiangDayQuery query = new KhoiLuongGiangDayQuery();
			
				query.AppendEquals(KhoiLuongGiangDayColumn.MaKhoiLuong, mock.MaKhoiLuong.ToString());
				if(mock.MaKetQua != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.MaKetQua, mock.MaKetQua.ToString());
				if(mock.MaToaNha != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.MaToaNha, mock.MaToaNha.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.MaLop, mock.MaLop.ToString());
				if(mock.MaNhom != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.MaNhom, mock.MaNhom.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.PhanLoai != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.PhanLoai, mock.PhanLoai.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.DienGiai != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.DienGiai, mock.DienGiai.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SiSoLop != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.SiSoLop, mock.SiSoLop.ToString());
				if(mock.SoNhom != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.SoNhom, mock.SoNhom.ToString());
				if(mock.MaDiaDiem != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.MaDiaDiem, mock.MaDiaDiem.ToString());
				if(mock.NgayBatDau != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.NgayBatDau, mock.NgayBatDau.ToString());
				if(mock.NgayKetThuc != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.NgayKetThuc, mock.NgayKetThuc.ToString());
				if(mock.ChatLuongCao != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.ChatLuongCao, mock.ChatLuongCao.ToString());
				if(mock.NgoaiGio != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.NgoaiGio, mock.NgoaiGio.ToString());
				if(mock.TrongGio != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.TrongGio, mock.TrongGio.ToString());
				if(mock.HeSoLopDong != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.HeSoLopDong, mock.HeSoLopDong.ToString());
				if(mock.HeSoCoSo != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.HeSoCoSo, mock.HeSoCoSo.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				if(mock.HeSoThanhPhan != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.HeSoThanhPhan, mock.HeSoThanhPhan.ToString());
				if(mock.HeSoTrongGio != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.HeSoTrongGio, mock.HeSoTrongGio.ToString());
				if(mock.HeSoNgoaiGio != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.HeSoNgoaiGio, mock.HeSoNgoaiGio.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.LoaiHocKy != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.LoaiHocKy, mock.LoaiHocKy.ToString());
				if(mock.ThoiKhoaBieu != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.ThoiKhoaBieu, mock.ThoiKhoaBieu.ToString());
				if(mock.NgayTao != null)
					query.AppendEquals(KhoiLuongGiangDayColumn.NgayTao, mock.NgayTao.ToString());
				
				TList<KhoiLuongGiangDay> results = DataRepository.KhoiLuongGiangDayProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KhoiLuongGiangDay Entity with mock values.
		///</summary>
		static public KhoiLuongGiangDay CreateMockInstance_Generated(TransactionManager tm)
		{		
			KhoiLuongGiangDay mock = new KhoiLuongGiangDay();
						
			mock.MaToaNha = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhom = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.DienGiai = TestUtility.Instance.RandomString(49, false);;
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.SoNhom = TestUtility.Instance.RandomNumber();
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			mock.NgayBatDau = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThuc = TestUtility.Instance.RandomDateTime();
			mock.ChatLuongCao = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThanhPhan = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiHocKy = TestUtility.Instance.RandomNumber();
			mock.ThoiKhoaBieu = TestUtility.Instance.RandomString(49, false);;
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			
			//OneToOneRelationship
			KetQuaTinh mockKetQuaTinhByMaKetQua = KetQuaTinhTest.CreateMockInstance(tm);
			DataRepository.KetQuaTinhProvider.Insert(tm, mockKetQuaTinhByMaKetQua);
			mock.MaKetQua = mockKetQuaTinhByMaKetQua.MaKetQua;
		
			// create a temporary collection and add the item to it
			TList<KhoiLuongGiangDay> tempMockCollection = new TList<KhoiLuongGiangDay>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KhoiLuongGiangDay)mock;
		}
		
		
		///<summary>
		///  Update the Typed KhoiLuongGiangDay Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KhoiLuongGiangDay mock)
		{
			mock.MaToaNha = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhom = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.DienGiai = TestUtility.Instance.RandomString(49, false);;
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.SoNhom = TestUtility.Instance.RandomNumber();
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			mock.NgayBatDau = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThuc = TestUtility.Instance.RandomDateTime();
			mock.ChatLuongCao = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoThanhPhan = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoTrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.LoaiHocKy = TestUtility.Instance.RandomNumber();
			mock.ThoiKhoaBieu = TestUtility.Instance.RandomString(49, false);;
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			
			//OneToOneRelationship
			KetQuaTinh mockKetQuaTinhByMaKetQua = KetQuaTinhTest.CreateMockInstance(tm);
			DataRepository.KetQuaTinhProvider.Insert(tm, mockKetQuaTinhByMaKetQua);
			mock.MaKetQua = mockKetQuaTinhByMaKetQua.MaKetQua;
					
		}
		#endregion
    }
}
