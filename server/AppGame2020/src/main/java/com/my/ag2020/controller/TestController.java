package com.my.ag2020.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.my.ag2020.service.TestService;
import com.my.ag2020.vo.TestVO;

@RestController
@RequestMapping("/test")
public class TestController {
	
	@Autowired
	private TestService service;
	
	@RequestMapping("/all")
	public List<TestVO> viewAll() {
		return service.viewAll();
	}

}
