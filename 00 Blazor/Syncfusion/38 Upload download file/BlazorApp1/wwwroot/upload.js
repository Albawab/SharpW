window.onUpload = (id, filename) => { 
    let url = "https://localhost:44394/api/SampleData/Download?filename=" + filename; 
    window.location.href = url; 
};

