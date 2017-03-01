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
	/// Represents the DataRepository.GiangVienChoDuyetHoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienChoDuyetHoSoDataSourceDesigner))]
	public class GiangVienChoDuyetHoSoDataSource : ProviderDataSource<GiangVienChoDuyetHoSo, GiangVienChoDuyetHoSoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoDataSource class.
		/// </summary>
		public GiangVienChoDuyetHoSoDataSource() : base(new GiangVienChoDuyetHoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienChoDuyetHoSoDataSourceView used by the GiangVienChoDuyetHoSoDataSource.
		/// </summary>
		protected GiangVienChoDuyetHoSoDataSourceView GiangVienChoDuyetHoSoView
		{
			get { return ( View as GiangVienChoDuyetHoSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienChoDuyetHoSoDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienChoDuyetHoSoSelectMethod SelectMethod
		{
			get
			{
				GiangVienChoDuyetHoSoSelectMethod selectMethod = GiangVienChoDuyetHoSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienChoDuyetHoSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienChoDuyetHoSoDataSourceView class that is to be
		/// used by the GiangVienChoDuyetHoSoDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienChoDuyetHoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienChoDuyetHoSo, GiangVienChoDuyetHoSoKey> GetNewDataSourceView()
		{
			return new GiangVienChoDuyetHoSoDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienChoDuyetHoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienChoDuyetHoSoDataSourceView : ProviderDataSourceView<GiangVienChoDuyetHoSo, GiangVienChoDuyetHoSoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienChoDuyetHoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienChoDuyetHoSoDataSourceView(GiangVienChoDuyetHoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienChoDuyetHoSoDataSource GiangVienChoDuyetHoSoOwner
		{
			get { return Owner as GiangVienChoDuyetHoSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienChoDuyetHoSoSelectMethod SelectMethod
		{
			get { return GiangVienChoDuyetHoSoOwner.SelectMethod; }
			set { GiangVienChoDuyetHoSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienChoDuyetHoSoService GiangVienChoDuyetHoSoProvider
		{
			get { return Provider as GiangVienChoDuyetHoSoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienChoDuyetHoSo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienChoDuyetHoSo> results = null;
			GiangVienChoDuyetHoSo item;
			count = 0;
			
			System.Int32 _id;
			System.String sp202_MaDonVi;
			System.Int32 sp202_MaHocHam;
			System.Int32 sp202_MaHocVi;
			System.String sp202_MaTinhTrang;
			System.String sp200_MaDonVi;

			switch ( SelectMethod )
			{
				case GiangVienChoDuyetHoSoSelectMethod.Get:
					GiangVienChoDuyetHoSoKey entityKey  = new GiangVienChoDuyetHoSoKey();
					entityKey.Load(values);
					item = GiangVienChoDuyetHoSoProvider.Get(entityKey);
					results = new TList<GiangVienChoDuyetHoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienChoDuyetHoSoSelectMethod.GetAll:
                    results = GiangVienChoDuyetHoSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienChoDuyetHoSoSelectMethod.GetPaged:
					results = GiangVienChoDuyetHoSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienChoDuyetHoSoSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienChoDuyetHoSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienChoDuyetHoSoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienChoDuyetHoSoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienChoDuyetHoSoProvider.GetById(_id);
					results = new TList<GiangVienChoDuyetHoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case GiangVienChoDuyetHoSoSelectMethod.GetMaDonViMaHocHamMaHocViMaTinhTrang:
					sp202_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp202_MaHocHam = (System.Int32) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32));
					sp202_MaHocVi = (System.Int32) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32));
					sp202_MaTinhTrang = (System.String) EntityUtil.ChangeType(values["MaTinhTrang"], typeof(System.String));
					results = GiangVienChoDuyetHoSoProvider.GetMaDonViMaHocHamMaHocViMaTinhTrang(sp202_MaDonVi, sp202_MaHocHam, sp202_MaHocVi, sp202_MaTinhTrang, StartIndex, PageSize);
					break;
				case GiangVienChoDuyetHoSoSelectMethod.GetByMaDonVi:
					sp200_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = GiangVienChoDuyetHoSoProvider.GetByMaDonVi(sp200_MaDonVi, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == GiangVienChoDuyetHoSoSelectMethod.Get || SelectMethod == GiangVienChoDuyetHoSoSelectMethod.GetById )
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
				GiangVienChoDuyetHoSo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienChoDuyetHoSoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienChoDuyetHoSo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienChoDuyetHoSoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienChoDuyetHoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienChoDuyetHoSoDataSource class.
	/// </summary>
	public class GiangVienChoDuyetHoSoDataSourceDesigner : ProviderDataSourceDesigner<GiangVienChoDuyetHoSo, GiangVienChoDuyetHoSoKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoDataSourceDesigner class.
		/// </summary>
		public GiangVienChoDuyetHoSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienChoDuyetHoSoSelectMethod SelectMethod
		{
			get { return ((GiangVienChoDuyetHoSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienChoDuyetHoSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienChoDuyetHoSoDataSourceActionList

	/// <summary>
	/// Supports the GiangVienChoDuyetHoSoDataSourceDesigner class.
	/// </summary>
	internal class GiangVienChoDuyetHoSoDataSourceActionList : DesignerActionList
	{
		private GiangVienChoDuyetHoSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienChoDuyetHoSoDataSourceActionList(GiangVienChoDuyetHoSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienChoDuyetHoSoSelectMethod SelectMethod
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

	#endregion GiangVienChoDuyetHoSoDataSourceActionList
	
	#endregion GiangVienChoDuyetHoSoDataSourceDesigner
	
	#region GiangVienChoDuyetHoSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienChoDuyetHoSoDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienChoDuyetHoSoSelectMethod
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
		/// Represents the GetMaDonViMaHocHamMaHocViMaTinhTrang method.
		/// </summary>
		GetMaDonViMaHocHamMaHocViMaTinhTrang,
		/// <summary>
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi
	}
	
	#endregion GiangVienChoDuyetHoSoSelectMethod

	#region GiangVienChoDuyetHoSoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChoDuyetHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChoDuyetHoSoFilter : SqlFilter<GiangVienChoDuyetHoSoColumn>
	{
	}
	
	#endregion GiangVienChoDuyetHoSoFilter

	#region GiangVienChoDuyetHoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChoDuyetHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChoDuyetHoSoExpressionBuilder : SqlExpressionBuilder<GiangVienChoDuyetHoSoColumn>
	{
	}
	
	#endregion GiangVienChoDuyetHoSoExpressionBuilder	

	#region GiangVienChoDuyetHoSoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienChoDuyetHoSoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChoDuyetHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChoDuyetHoSoProperty : ChildEntityProperty<GiangVienChoDuyetHoSoChildEntityTypes>
	{
	}
	
	#endregion GiangVienChoDuyetHoSoProperty
}

