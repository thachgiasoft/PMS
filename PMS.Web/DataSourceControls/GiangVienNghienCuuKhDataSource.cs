#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.GiangVienNghienCuuKhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienNghienCuuKhDataSourceDesigner))]
	public class GiangVienNghienCuuKhDataSource : ProviderDataSource<GiangVienNghienCuuKh, GiangVienNghienCuuKhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhDataSource class.
		/// </summary>
		public GiangVienNghienCuuKhDataSource() : base(new GiangVienNghienCuuKhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienNghienCuuKhDataSourceView used by the GiangVienNghienCuuKhDataSource.
		/// </summary>
		protected GiangVienNghienCuuKhDataSourceView GiangVienNghienCuuKhView
		{
			get { return ( View as GiangVienNghienCuuKhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienNghienCuuKhDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienNghienCuuKhSelectMethod SelectMethod
		{
			get
			{
				GiangVienNghienCuuKhSelectMethod selectMethod = GiangVienNghienCuuKhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienNghienCuuKhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienNghienCuuKhDataSourceView class that is to be
		/// used by the GiangVienNghienCuuKhDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienNghienCuuKhDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienNghienCuuKh, GiangVienNghienCuuKhKey> GetNewDataSourceView()
		{
			return new GiangVienNghienCuuKhDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the GiangVienNghienCuuKhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienNghienCuuKhDataSourceView : ProviderDataSourceView<GiangVienNghienCuuKh, GiangVienNghienCuuKhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienNghienCuuKhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienNghienCuuKhDataSourceView(GiangVienNghienCuuKhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienNghienCuuKhDataSource GiangVienNghienCuuKhOwner
		{
			get { return Owner as GiangVienNghienCuuKhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienNghienCuuKhSelectMethod SelectMethod
		{
			get { return GiangVienNghienCuuKhOwner.SelectMethod; }
			set { GiangVienNghienCuuKhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienNghienCuuKhService GiangVienNghienCuuKhProvider
		{
			get { return Provider as GiangVienNghienCuuKhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienNghienCuuKh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienNghienCuuKh> results = null;
			GiangVienNghienCuuKh item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maNckh_nullable;
			System.Int32 _maGiangVien;
			System.Int32? _maVaiTro_nullable;
			System.Int32? _mucDoHoanThanh_nullable;

			switch ( SelectMethod )
			{
				case GiangVienNghienCuuKhSelectMethod.Get:
					GiangVienNghienCuuKhKey entityKey  = new GiangVienNghienCuuKhKey();
					entityKey.Load(values);
					item = GiangVienNghienCuuKhProvider.Get(entityKey);
					results = new TList<GiangVienNghienCuuKh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienNghienCuuKhSelectMethod.GetAll:
                    results = GiangVienNghienCuuKhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienNghienCuuKhSelectMethod.GetPaged:
					results = GiangVienNghienCuuKhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienNghienCuuKhSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienNghienCuuKhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienNghienCuuKhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienNghienCuuKhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienNghienCuuKhProvider.GetById(_id);
					results = new TList<GiangVienNghienCuuKh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienNghienCuuKhSelectMethod.GetByMaNckh:
					_maNckh_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaNckh"], typeof(System.Int32?));
					results = GiangVienNghienCuuKhProvider.GetByMaNckh(_maNckh_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienNghienCuuKhSelectMethod.GetByMaGiangVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					results = GiangVienNghienCuuKhProvider.GetByMaGiangVien(_maGiangVien, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienNghienCuuKhSelectMethod.GetByMaVaiTro:
					_maVaiTro_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaVaiTro"], typeof(System.Int32?));
					results = GiangVienNghienCuuKhProvider.GetByMaVaiTro(_maVaiTro_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienNghienCuuKhSelectMethod.GetByMucDoHoanThanh:
					_mucDoHoanThanh_nullable = (System.Int32?) EntityUtil.ChangeType(values["MucDoHoanThanh"], typeof(System.Int32?));
					results = GiangVienNghienCuuKhProvider.GetByMucDoHoanThanh(_mucDoHoanThanh_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == GiangVienNghienCuuKhSelectMethod.Get || SelectMethod == GiangVienNghienCuuKhSelectMethod.GetById )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				GiangVienNghienCuuKh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienNghienCuuKhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<GiangVienNghienCuuKh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienNghienCuuKhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienNghienCuuKhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienNghienCuuKhDataSource class.
	/// </summary>
	public class GiangVienNghienCuuKhDataSourceDesigner : ProviderDataSourceDesigner<GiangVienNghienCuuKh, GiangVienNghienCuuKhKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhDataSourceDesigner class.
		/// </summary>
		public GiangVienNghienCuuKhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienNghienCuuKhSelectMethod SelectMethod
		{
			get { return ((GiangVienNghienCuuKhDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new GiangVienNghienCuuKhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienNghienCuuKhDataSourceActionList

	/// <summary>
	/// Supports the GiangVienNghienCuuKhDataSourceDesigner class.
	/// </summary>
	internal class GiangVienNghienCuuKhDataSourceActionList : DesignerActionList
	{
		private GiangVienNghienCuuKhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienNghienCuuKhDataSourceActionList(GiangVienNghienCuuKhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienNghienCuuKhSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion GiangVienNghienCuuKhDataSourceActionList
	
	#endregion GiangVienNghienCuuKhDataSourceDesigner
	
	#region GiangVienNghienCuuKhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienNghienCuuKhDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienNghienCuuKhSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByMaNckh method.
		/// </summary>
		GetByMaNckh,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByMaVaiTro method.
		/// </summary>
		GetByMaVaiTro,
		/// <summary>
		/// Represents the GetByMucDoHoanThanh method.
		/// </summary>
		GetByMucDoHoanThanh
	}
	
	#endregion GiangVienNghienCuuKhSelectMethod

	#region GiangVienNghienCuuKhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienNghienCuuKh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienNghienCuuKhFilter : SqlFilter<GiangVienNghienCuuKhColumn>
	{
	}
	
	#endregion GiangVienNghienCuuKhFilter

	#region GiangVienNghienCuuKhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienNghienCuuKh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienNghienCuuKhExpressionBuilder : SqlExpressionBuilder<GiangVienNghienCuuKhColumn>
	{
	}
	
	#endregion GiangVienNghienCuuKhExpressionBuilder	

	#region GiangVienNghienCuuKhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienNghienCuuKhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienNghienCuuKh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienNghienCuuKhProperty : ChildEntityProperty<GiangVienNghienCuuKhChildEntityTypes>
	{
	}
	
	#endregion GiangVienNghienCuuKhProperty
}

