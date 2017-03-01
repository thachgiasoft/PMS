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
	/// Represents the DataRepository.GiangVienHoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienHoSoDataSourceDesigner))]
	public class GiangVienHoSoDataSource : ProviderDataSource<GiangVienHoSo, GiangVienHoSoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoDataSource class.
		/// </summary>
		public GiangVienHoSoDataSource() : base(new GiangVienHoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienHoSoDataSourceView used by the GiangVienHoSoDataSource.
		/// </summary>
		protected GiangVienHoSoDataSourceView GiangVienHoSoView
		{
			get { return ( View as GiangVienHoSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienHoSoDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienHoSoSelectMethod SelectMethod
		{
			get
			{
				GiangVienHoSoSelectMethod selectMethod = GiangVienHoSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienHoSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienHoSoDataSourceView class that is to be
		/// used by the GiangVienHoSoDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienHoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienHoSo, GiangVienHoSoKey> GetNewDataSourceView()
		{
			return new GiangVienHoSoDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienHoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienHoSoDataSourceView : ProviderDataSourceView<GiangVienHoSo, GiangVienHoSoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienHoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienHoSoDataSourceView(GiangVienHoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienHoSoDataSource GiangVienHoSoOwner
		{
			get { return Owner as GiangVienHoSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienHoSoSelectMethod SelectMethod
		{
			get { return GiangVienHoSoOwner.SelectMethod; }
			set { GiangVienHoSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienHoSoService GiangVienHoSoProvider
		{
			get { return Provider as GiangVienHoSoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienHoSo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienHoSo> results = null;
			GiangVienHoSo item;
			count = 0;
			
			System.Int32 _maHoSo;
			System.Int32 _maGiangVien;

			switch ( SelectMethod )
			{
				case GiangVienHoSoSelectMethod.Get:
					GiangVienHoSoKey entityKey  = new GiangVienHoSoKey();
					entityKey.Load(values);
					item = GiangVienHoSoProvider.Get(entityKey);
					results = new TList<GiangVienHoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienHoSoSelectMethod.GetAll:
                    results = GiangVienHoSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienHoSoSelectMethod.GetPaged:
					results = GiangVienHoSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienHoSoSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienHoSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienHoSoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienHoSoSelectMethod.GetByMaHoSoMaGiangVien:
					_maHoSo = ( values["MaHoSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHoSo"], typeof(System.Int32)) : (int)0;
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					item = GiangVienHoSoProvider.GetByMaHoSoMaGiangVien(_maHoSo, _maGiangVien);
					results = new TList<GiangVienHoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienHoSoSelectMethod.GetByMaGiangVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					results = GiangVienHoSoProvider.GetByMaGiangVien(_maGiangVien, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienHoSoSelectMethod.GetByMaHoSo:
					_maHoSo = ( values["MaHoSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHoSo"], typeof(System.Int32)) : (int)0;
					results = GiangVienHoSoProvider.GetByMaHoSo(_maHoSo, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == GiangVienHoSoSelectMethod.Get || SelectMethod == GiangVienHoSoSelectMethod.GetByMaHoSoMaGiangVien )
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
				GiangVienHoSo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienHoSoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienHoSo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienHoSoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienHoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienHoSoDataSource class.
	/// </summary>
	public class GiangVienHoSoDataSourceDesigner : ProviderDataSourceDesigner<GiangVienHoSo, GiangVienHoSoKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoDataSourceDesigner class.
		/// </summary>
		public GiangVienHoSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienHoSoSelectMethod SelectMethod
		{
			get { return ((GiangVienHoSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienHoSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienHoSoDataSourceActionList

	/// <summary>
	/// Supports the GiangVienHoSoDataSourceDesigner class.
	/// </summary>
	internal class GiangVienHoSoDataSourceActionList : DesignerActionList
	{
		private GiangVienHoSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienHoSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienHoSoDataSourceActionList(GiangVienHoSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienHoSoSelectMethod SelectMethod
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

	#endregion GiangVienHoSoDataSourceActionList
	
	#endregion GiangVienHoSoDataSourceDesigner
	
	#region GiangVienHoSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienHoSoDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienHoSoSelectMethod
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
		/// Represents the GetByMaHoSoMaGiangVien method.
		/// </summary>
		GetByMaHoSoMaGiangVien,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByMaHoSo method.
		/// </summary>
		GetByMaHoSo
	}
	
	#endregion GiangVienHoSoSelectMethod

	#region GiangVienHoSoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoSoFilter : SqlFilter<GiangVienHoSoColumn>
	{
	}
	
	#endregion GiangVienHoSoFilter

	#region GiangVienHoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoSoExpressionBuilder : SqlExpressionBuilder<GiangVienHoSoColumn>
	{
	}
	
	#endregion GiangVienHoSoExpressionBuilder	

	#region GiangVienHoSoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienHoSoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoSoProperty : ChildEntityProperty<GiangVienHoSoChildEntityTypes>
	{
	}
	
	#endregion GiangVienHoSoProperty
}

