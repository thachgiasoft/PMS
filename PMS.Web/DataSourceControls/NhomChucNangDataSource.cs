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
	/// Represents the DataRepository.NhomChucNangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NhomChucNangDataSourceDesigner))]
	public class NhomChucNangDataSource : ProviderDataSource<NhomChucNang, NhomChucNangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomChucNangDataSource class.
		/// </summary>
		public NhomChucNangDataSource() : base(new NhomChucNangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NhomChucNangDataSourceView used by the NhomChucNangDataSource.
		/// </summary>
		protected NhomChucNangDataSourceView NhomChucNangView
		{
			get { return ( View as NhomChucNangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NhomChucNangDataSource control invokes to retrieve data.
		/// </summary>
		public NhomChucNangSelectMethod SelectMethod
		{
			get
			{
				NhomChucNangSelectMethod selectMethod = NhomChucNangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NhomChucNangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NhomChucNangDataSourceView class that is to be
		/// used by the NhomChucNangDataSource.
		/// </summary>
		/// <returns>An instance of the NhomChucNangDataSourceView class.</returns>
		protected override BaseDataSourceView<NhomChucNang, NhomChucNangKey> GetNewDataSourceView()
		{
			return new NhomChucNangDataSourceView(this, DefaultViewName);
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
	/// Supports the NhomChucNangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NhomChucNangDataSourceView : ProviderDataSourceView<NhomChucNang, NhomChucNangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomChucNangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NhomChucNangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NhomChucNangDataSourceView(NhomChucNangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NhomChucNangDataSource NhomChucNangOwner
		{
			get { return Owner as NhomChucNangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NhomChucNangSelectMethod SelectMethod
		{
			get { return NhomChucNangOwner.SelectMethod; }
			set { NhomChucNangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NhomChucNangService NhomChucNangProvider
		{
			get { return Provider as NhomChucNangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NhomChucNang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NhomChucNang> results = null;
			NhomChucNang item;
			count = 0;
			
			System.Int32 _maChucNang;
			System.Int32 _maNhomQuyen;

			switch ( SelectMethod )
			{
				case NhomChucNangSelectMethod.Get:
					NhomChucNangKey entityKey  = new NhomChucNangKey();
					entityKey.Load(values);
					item = NhomChucNangProvider.Get(entityKey);
					results = new TList<NhomChucNang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NhomChucNangSelectMethod.GetAll:
                    results = NhomChucNangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NhomChucNangSelectMethod.GetPaged:
					results = NhomChucNangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NhomChucNangSelectMethod.Find:
					if ( FilterParameters != null )
						results = NhomChucNangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NhomChucNangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NhomChucNangSelectMethod.GetByMaChucNangMaNhomQuyen:
					_maChucNang = ( values["MaChucNang"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaChucNang"], typeof(System.Int32)) : (int)0;
					_maNhomQuyen = ( values["MaNhomQuyen"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32)) : (int)0;
					item = NhomChucNangProvider.GetByMaChucNangMaNhomQuyen(_maChucNang, _maNhomQuyen);
					results = new TList<NhomChucNang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case NhomChucNangSelectMethod.GetByMaNhomQuyen:
					_maNhomQuyen = ( values["MaNhomQuyen"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32)) : (int)0;
					results = NhomChucNangProvider.GetByMaNhomQuyen(_maNhomQuyen, this.StartIndex, this.PageSize, out count);
					break;
				case NhomChucNangSelectMethod.GetByMaChucNang:
					_maChucNang = ( values["MaChucNang"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaChucNang"], typeof(System.Int32)) : (int)0;
					results = NhomChucNangProvider.GetByMaChucNang(_maChucNang, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == NhomChucNangSelectMethod.Get || SelectMethod == NhomChucNangSelectMethod.GetByMaChucNangMaNhomQuyen )
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
				NhomChucNang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NhomChucNangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NhomChucNang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NhomChucNangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NhomChucNangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NhomChucNangDataSource class.
	/// </summary>
	public class NhomChucNangDataSourceDesigner : ProviderDataSourceDesigner<NhomChucNang, NhomChucNangKey>
	{
		/// <summary>
		/// Initializes a new instance of the NhomChucNangDataSourceDesigner class.
		/// </summary>
		public NhomChucNangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NhomChucNangSelectMethod SelectMethod
		{
			get { return ((NhomChucNangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NhomChucNangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NhomChucNangDataSourceActionList

	/// <summary>
	/// Supports the NhomChucNangDataSourceDesigner class.
	/// </summary>
	internal class NhomChucNangDataSourceActionList : DesignerActionList
	{
		private NhomChucNangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NhomChucNangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NhomChucNangDataSourceActionList(NhomChucNangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NhomChucNangSelectMethod SelectMethod
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

	#endregion NhomChucNangDataSourceActionList
	
	#endregion NhomChucNangDataSourceDesigner
	
	#region NhomChucNangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NhomChucNangDataSource.SelectMethod property.
	/// </summary>
	public enum NhomChucNangSelectMethod
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
		/// Represents the GetByMaChucNangMaNhomQuyen method.
		/// </summary>
		GetByMaChucNangMaNhomQuyen,
		/// <summary>
		/// Represents the GetByMaNhomQuyen method.
		/// </summary>
		GetByMaNhomQuyen,
		/// <summary>
		/// Represents the GetByMaChucNang method.
		/// </summary>
		GetByMaChucNang
	}
	
	#endregion NhomChucNangSelectMethod

	#region NhomChucNangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomChucNangFilter : SqlFilter<NhomChucNangColumn>
	{
	}
	
	#endregion NhomChucNangFilter

	#region NhomChucNangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomChucNangExpressionBuilder : SqlExpressionBuilder<NhomChucNangColumn>
	{
	}
	
	#endregion NhomChucNangExpressionBuilder	

	#region NhomChucNangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NhomChucNangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NhomChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomChucNangProperty : ChildEntityProperty<NhomChucNangChildEntityTypes>
	{
	}
	
	#endregion NhomChucNangProperty
}

