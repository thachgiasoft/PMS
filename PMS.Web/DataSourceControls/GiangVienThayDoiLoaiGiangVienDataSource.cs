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
	/// Represents the DataRepository.GiangVienThayDoiLoaiGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienThayDoiLoaiGiangVienDataSourceDesigner))]
	public class GiangVienThayDoiLoaiGiangVienDataSource : ProviderDataSource<GiangVienThayDoiLoaiGiangVien, GiangVienThayDoiLoaiGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiLoaiGiangVienDataSource class.
		/// </summary>
		public GiangVienThayDoiLoaiGiangVienDataSource() : base(new GiangVienThayDoiLoaiGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienThayDoiLoaiGiangVienDataSourceView used by the GiangVienThayDoiLoaiGiangVienDataSource.
		/// </summary>
		protected GiangVienThayDoiLoaiGiangVienDataSourceView GiangVienThayDoiLoaiGiangVienView
		{
			get { return ( View as GiangVienThayDoiLoaiGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienThayDoiLoaiGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienThayDoiLoaiGiangVienSelectMethod SelectMethod
		{
			get
			{
				GiangVienThayDoiLoaiGiangVienSelectMethod selectMethod = GiangVienThayDoiLoaiGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienThayDoiLoaiGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienThayDoiLoaiGiangVienDataSourceView class that is to be
		/// used by the GiangVienThayDoiLoaiGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienThayDoiLoaiGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienThayDoiLoaiGiangVien, GiangVienThayDoiLoaiGiangVienKey> GetNewDataSourceView()
		{
			return new GiangVienThayDoiLoaiGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienThayDoiLoaiGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienThayDoiLoaiGiangVienDataSourceView : ProviderDataSourceView<GiangVienThayDoiLoaiGiangVien, GiangVienThayDoiLoaiGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiLoaiGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienThayDoiLoaiGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienThayDoiLoaiGiangVienDataSourceView(GiangVienThayDoiLoaiGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienThayDoiLoaiGiangVienDataSource GiangVienThayDoiLoaiGiangVienOwner
		{
			get { return Owner as GiangVienThayDoiLoaiGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienThayDoiLoaiGiangVienSelectMethod SelectMethod
		{
			get { return GiangVienThayDoiLoaiGiangVienOwner.SelectMethod; }
			set { GiangVienThayDoiLoaiGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienThayDoiLoaiGiangVienService GiangVienThayDoiLoaiGiangVienProvider
		{
			get { return Provider as GiangVienThayDoiLoaiGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienThayDoiLoaiGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienThayDoiLoaiGiangVien> results = null;
			GiangVienThayDoiLoaiGiangVien item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiangVienThayDoiLoaiGiangVienSelectMethod.Get:
					GiangVienThayDoiLoaiGiangVienKey entityKey  = new GiangVienThayDoiLoaiGiangVienKey();
					entityKey.Load(values);
					item = GiangVienThayDoiLoaiGiangVienProvider.Get(entityKey);
					results = new TList<GiangVienThayDoiLoaiGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienThayDoiLoaiGiangVienSelectMethod.GetAll:
                    results = GiangVienThayDoiLoaiGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienThayDoiLoaiGiangVienSelectMethod.GetPaged:
					results = GiangVienThayDoiLoaiGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienThayDoiLoaiGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienThayDoiLoaiGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienThayDoiLoaiGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienThayDoiLoaiGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienThayDoiLoaiGiangVienProvider.GetById(_id);
					results = new TList<GiangVienThayDoiLoaiGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == GiangVienThayDoiLoaiGiangVienSelectMethod.Get || SelectMethod == GiangVienThayDoiLoaiGiangVienSelectMethod.GetById )
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
				GiangVienThayDoiLoaiGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienThayDoiLoaiGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienThayDoiLoaiGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienThayDoiLoaiGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienThayDoiLoaiGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienThayDoiLoaiGiangVienDataSource class.
	/// </summary>
	public class GiangVienThayDoiLoaiGiangVienDataSourceDesigner : ProviderDataSourceDesigner<GiangVienThayDoiLoaiGiangVien, GiangVienThayDoiLoaiGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiLoaiGiangVienDataSourceDesigner class.
		/// </summary>
		public GiangVienThayDoiLoaiGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiLoaiGiangVienSelectMethod SelectMethod
		{
			get { return ((GiangVienThayDoiLoaiGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienThayDoiLoaiGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienThayDoiLoaiGiangVienDataSourceActionList

	/// <summary>
	/// Supports the GiangVienThayDoiLoaiGiangVienDataSourceDesigner class.
	/// </summary>
	internal class GiangVienThayDoiLoaiGiangVienDataSourceActionList : DesignerActionList
	{
		private GiangVienThayDoiLoaiGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiLoaiGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienThayDoiLoaiGiangVienDataSourceActionList(GiangVienThayDoiLoaiGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiLoaiGiangVienSelectMethod SelectMethod
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

	#endregion GiangVienThayDoiLoaiGiangVienDataSourceActionList
	
	#endregion GiangVienThayDoiLoaiGiangVienDataSourceDesigner
	
	#region GiangVienThayDoiLoaiGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienThayDoiLoaiGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienThayDoiLoaiGiangVienSelectMethod
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
		GetById
	}
	
	#endregion GiangVienThayDoiLoaiGiangVienSelectMethod

	#region GiangVienThayDoiLoaiGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiLoaiGiangVienFilter : SqlFilter<GiangVienThayDoiLoaiGiangVienColumn>
	{
	}
	
	#endregion GiangVienThayDoiLoaiGiangVienFilter

	#region GiangVienThayDoiLoaiGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiLoaiGiangVienExpressionBuilder : SqlExpressionBuilder<GiangVienThayDoiLoaiGiangVienColumn>
	{
	}
	
	#endregion GiangVienThayDoiLoaiGiangVienExpressionBuilder	

	#region GiangVienThayDoiLoaiGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienThayDoiLoaiGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiLoaiGiangVienProperty : ChildEntityProperty<GiangVienThayDoiLoaiGiangVienChildEntityTypes>
	{
	}
	
	#endregion GiangVienThayDoiLoaiGiangVienProperty
}

